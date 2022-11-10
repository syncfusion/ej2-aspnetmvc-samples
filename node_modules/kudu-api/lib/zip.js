"use strict";

var fs = require("fs");

module.exports = function zip(request) {
    return {
        download: function download(fromPath, toPath, cb) {
            request("/api/zip/" + fromPath, function zipDownloadCallback(err, response) {
                if (err) {
                    return cb(err);
                }

                cb(null, response);
            }).pipe(fs.createWriteStream(toPath));
        },
        upload: function upload(fromPath, toPath, cb) {
            fs.createReadStream(fromPath).pipe(request.put({
                uri: "/api/zip/" + toPath,
            }, function zipUploadCallback(err, response, body) {
                if (err) {
                    return cb(err);
                }

                cb(null, body, response);
            }));
        }
    };
};
