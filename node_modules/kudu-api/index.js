var request = require("request");
var scm = require("./lib/scm");
var command = require("./lib/command");
var vfs = require("./lib/vfs");
var zip = require("./lib/zip");
var deployment = require("./lib/deployment");
var sshkey = require("./lib/sshkey");
var environment = require("./lib/environment");
var settings = require("./lib/settings");
var dump = require("./lib/dump");
var diagnostics = require("./lib/diagnostics");
var logs = require("./lib/logs");
var extensions = require("./lib/extensions");
var webjobs = require("./lib/webjobs");

module.exports = function api(options) {
    // Backward compat for old method signature
    if (typeof options === "string") {
        options = {
            website: options,
            username: arguments[1],
            password: arguments[2]
        };
    }

    //options: website, username, password, basic (hashed)
    var website = options.website,
        headers = {};

    if(options.username && options.password){
        headers.Authorization =  "Basic " +
            new Buffer(options.username + ":" + options.password)
            .toString("base64");
    }

    if(options.basic){
      headers.Authorization =  "Basic " + options.basic;
    }

    var r = request.defaults({
        baseUrl: "https://" + website + ".scm.azurewebsites.net/",
        headers: headers,
    });
    return {
        scm: scm(r),
        command: command(r),
        vfs: vfs(r),
        zip: zip(r),
        deployment: deployment(r),
        sshkey: sshkey(r),
        environment: environment(r),
        settings: settings(r),
        dump: dump(r),
        diagnostics: diagnostics(r),
        logs: logs(r),
        extensions: extensions(r),
        webjobs: webjobs(r)
    };
};
