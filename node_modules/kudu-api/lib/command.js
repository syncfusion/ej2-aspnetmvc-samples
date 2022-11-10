"use strict";

module.exports = function command(request) {
    return {
        exec: function exec(command, dir, cb) {
            if (typeof dir === "function") {
                cb = dir;
                dir = "";
            }

            request.post({
                uri: "/api/command",
                json: {
                    command: command,
                    dir: dir
                }
            }, function execCallback(err, response, body) {
                if (err) {
                    return cb(err);
                }

                cb(null, body, response);
            });
        }
    };
};
