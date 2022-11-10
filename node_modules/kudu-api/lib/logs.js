"use strict";

module.exports = function logs(request) {
    return {
        recent: function recent(query, cb) {
            if (typeof query === "function") {
                cb = query;
                query = {};
            }
            request({
                uri: "/api/logs/recent",
                qs: query
            }, function logsRecentCallback(err, response, body) {
                if (err) {
                    return cb(err);
                }

                cb(null, JSON.parse(body), response);
            });
        }
    };
};
