"use strict";

module.exports = function scm(request) {
    return {
        info: function info(cb) {
            request("/api/scm/info", function scmInfoCallback(err, response, body) {
                if (err) {
                    return cb(err);
                }

                cb(null, JSON.parse(body), response);
            });
        },
        clean: function clean(cb) {
            request.post("/api/scm/clean", function scmCleanCallback(err, response, body) {
                if (err) {
                    return cb(err);
                }

                cb(null, body, response);
            });
        },
        del: function del(cb) {
            request.del("/api/scm", function scmDelCallback(err, response, body) {
                cb(err, body, response);
            });
        }
    };
};
