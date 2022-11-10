"use strict";

module.exports = function diagnostics(request) {
    return {
        list: function list(cb) {
            request("/api/diagnostics/settings", function diagnosticsListCallback(err, response, body) {
                if (err) {
                    return cb(err);
                }

                cb(null, JSON.parse(body), response);
            });
        },
        get: function get(key, cb) {
            request("/api/diagnostics/settings/" + key, function diagnosticsGetCallback(err, response, body) {
                if (err) {
                    return cb(err);
                }

                if (404 === response.statusCode) {
                    return cb(JSON.parse(body));
                }

                cb(null, JSON.parse(body), response);
            });
        },
        del: function del(key, cb) {
            request.del("/api/diagnostics/settings/" + key, function diagnosticsDelCallback(err, response, body) {
                if (err) {
                    return cb(err);
                }

                cb(null, body, response);
            });
        },
        set: function set(settings, cb) {
            request.post({
                uri: "/api/diagnostics/settings/",
                json: settings
            }, function diagnosticsSetCallback(err, response, body) {
                if (err) {
                    return cb(err);
                }

                cb(null, body, response);
            });
        }
    };
};
