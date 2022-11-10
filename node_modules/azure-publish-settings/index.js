"use strict";

var fs = require("fs");
var xml = require("xml2js");
var Promise = require("bluebird");

var siteNamePattern = /\/\/([a-z0-9\-]+)\./i;

var methodHandlers = {
    web: function (profile, attr) {
        profile.iisSite = attr.msdeploySite;
    },
    ftp: function (profile, attr) {
        var passive = attr.ftpPassiveMode;
        passive = passive && passive.toLowerCase();

        profile.passive = passive === "true";
    }
};

function parseMethod(method) {
    method = method && method.toLowerCase();

    return method === "msdeploy"
        ? "web"
        : method;
}

function parseName(url) {
    return siteNamePattern.exec(url)[1];
}

function read(publishSettingsPath, callback) {
    var settings = {
        profiles: []
    };

    function handleProfile(item, index) {
        var attr = item.attr;
        var method = parseMethod(attr.publishMethod);

        if (index === 0) {
            settings.url = attr.destinationAppUrl;
            settings.name = parseName(attr.destinationAppUrl);
        }

        var profile = {
            method: method,
            name: attr.profileName,
            url: attr.publishUrl,
            username: attr.userName,
            password: attr.userPWD
        };

        if (!settings[method]) {
            settings[method] = profile;
        }

        var handler = methodHandlers[method];
        if (handler) {
            handler(profile, attr);
        }

        settings.profiles.push(profile);
    }

    function handleSettings(err, data) {
        if (err) {
            return callback(err);
        }

        try {
            data.publishData.publishProfile.forEach(handleProfile);
        } catch (e) {
            return callback(e);
        }

        if (settings.web) {
            settings.kudu = {
                website: settings.name,
                username: settings.web.username,
                password: settings.web.password
            };
        }

        return callback(null, settings);
    }

    function handleBuffer(err, buffer) {
        if (err) {
            return callback(err);
        }

        var options = {
            attrkey: "attr"
        };

        try {
            xml.parseString(buffer, options, handleSettings);
        } catch (e) {
            return callback(e);
        }
    }

    fs.readFile(publishSettingsPath, handleBuffer);
}

module.exports = {
    read: read,
    readAsync: Promise.promisify(read)
};
