"use strict";

module.exports = function sshkey(request) {
    return {
        get: function get(generate, cb) {
            if (typeof generate === "function") {
                cb = generate;
                generate = false;
            }

            var url = "/api/sshkey/" + (generate ? "?ensurePublicKey=1" : "");
            request(url, function sshkeyGetCallback(err, response, body) {
                if (err) {
                    return cb(err);
                }

                cb(null, JSON.parse(body), response);
            });
        }
    };
};
