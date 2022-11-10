"use strict";

var fs = require("fs"),
    path = require("path");

function resolveError(response, message) {
    if (response.statusCode < 400) {
        return;
    }

    message = message
        ? message + " "
        : "";

    message += "Status code " + response.statusCode + " (" + response.statusMessage + ").";

    if (response.body) {
        message += " " + response.body;
    }

    return new Error(message);
}

function createUploadHeaders(localPath) {
    var fileName = path.basename(localPath),
        contentType = path.extname(localPath).toLowerCase() === ".zip"
            ? "application/zip"
            : "application/octet-stream";

    return {
        "Content-Disposition": "attachment; filename=" + fileName,
        "Content-Type": contentType
    };
}

module.exports = function webjobs(request) {
    return {
        listAll: function listAll(cb) {
            request("/api/webjobs", function (err, response) {
                err = err || resolveError(response, "Error listing all webjobs.");
                var data = err
                    ? null
                    : JSON.parse(response.body);

                cb(err, data, response);
            });
        },

        listTriggered: function listTriggered(cb) {
            request("/api/triggeredwebjobs", function (err, response) {
                err = err || resolveError(response, "Error listing triggered webjobs.");
                var data = err
                    ? null
                    : JSON.parse(response.body);

                cb(err, data, response);
            });
        },

        listTriggeredAsSwagger: function listTriggeredAsSwagger(cb) {
            request("/api/triggeredwebjobsswagger", function (err, response) {
                err = err || resolveError(response, "Error listing triggered webjobs as swagger.");
                var data = err
                    ? null
                    : JSON.parse(response.body);

                cb(err, data, response);
            });
        },

        getTriggered: function getTriggered(name, cb) {
            request("/api/triggeredwebjobs/" + encodeURIComponent(name), function (err, response) {
                err = err || resolveError(response, "Error getting triggered webjob with name '" + name + "'.");
                var data = err
                    ? null
                    : JSON.parse(response.body);

                cb(err, data, response);
            });
        },

        uploadTriggered: function uploadTriggered(name, localPath, cb) {
            var options = {
                uri: "/api/triggeredwebjobs/" + encodeURIComponent(name),
                headers: createUploadHeaders(localPath)
            };

            fs.createReadStream(localPath)
                .on("error", cb)
                .pipe(request.put(options, function (err, response) {
                    err = err || resolveError(response, "Error uploading triggered webjob with name '" + name + "'.");
                    var data = err
                        ? null
                        : JSON.parse(response.body);

                    cb(err, data, response);
                }));
        },

        deleteTriggered: function deleteTriggered(name, cb) {
            request.del("/api/triggeredwebjobs/" + encodeURIComponent(name), function (err, response) {
                err = err || resolveError(response, "Error deleting triggered webjob with name '" + name + "'.");

                cb(err, response);
            });
        },

        runTriggered: function runTriggered(name, args, cb) {
            var url = "/api/triggeredwebjobs/" + encodeURIComponent(name) + "/run";

            if (typeof args === "function") {
                cb = args;
            } else if (typeof args === "string") {
                url += "?arguments=" + encodeURIComponent(args);
            }

            request.post(url, function (err, response) {
                err = err || resolveError(response, "Error running triggered webjob with name '" + name + "'.");

                cb(err, response);
            });
        },

        listTriggeredHistory: function listTriggeredHistory(name, cb) {
            request("/api/triggeredwebjobs/" + encodeURIComponent(name) + "/history", function (err, response) {
                err = err || resolveError(response, "Error listing history for triggered webjob with name '" + name + "'.");
                var data = err
                    ? null
                    : JSON.parse(response.body);

                cb(err, data, response);
            });
        },

        getTriggeredHistory: function getTriggeredHistory(name, id, cb) {
            request("/api/triggeredwebjobs/" + encodeURIComponent(name) + "/history/" + encodeURIComponent(id), function (err, response) {
                err = err || resolveError(response, "Error getting history for triggered webjob with name '" + name + "' and id '" + id + "'.");
                var data = err
                    ? null
                    : JSON.parse(response.body);

                cb(err, data, response);
            });
        },

        listContinuous: function listContinuous(cb) {
            request("/api/continuouswebjobs", function (err, response) {
                err = err || resolveError(response, "Error listing continuous webjobs.");
                var data = err
                    ? null
                    : JSON.parse(response.body);

                cb(err, data, response);
            });
        },

        getContinuous: function getContinuous(name, cb) {
            request("/api/continuouswebjobs/" + encodeURIComponent(name), function (err, response) {
                err = err || resolveError(response, "Error getting continuous webjob with name '" + name + "'.");
                var data = err
                    ? null
                    : JSON.parse(response.body);

                cb(err, data, response);
            });
        },

        uploadContinuous: function uploadContinuous(name, localPath, cb) {
            var options = {
                uri: "/api/continuouswebjobs/" + encodeURIComponent(name),
                headers: createUploadHeaders(localPath)
            };

            fs.createReadStream(localPath)
                .on("error", cb)
                .pipe(request.put(options, function (err, response) {
                    err = err || resolveError(response, "Error uploading continuous webjob with name '" + name + "'.");
                    var data = err
                        ? null
                        : JSON.parse(response.body);

                    cb(err, data, response);
                }));
        },

        deleteContinuous: function deleteContinuous(name, cb) {
            request.del("/api/continuouswebjobs/" + encodeURIComponent(name), function (err, response) {
                err = err || resolveError(response, "Error deleting continuous webjob with name '" + name + "'.");

                cb(err, response);
            });
        },

        startContinuous: function startContinuous(name, cb) {
            request.post("/api/continuouswebjobs/" + encodeURIComponent(name) + "/start", function (err, response) {
                err = err || resolveError(response, "Error starting continuous webjob with name '" + name + "'.");

                cb(err, response);
            });
        },

        stopContinuous: function stopContinuous(name, cb) {
            request.post("/api/continuouswebjobs/" + encodeURIComponent(name) + "/stop", function (err, response) {
                err = err || resolveError(response, "Error stopping continuous webjob with name '" + name + "'.");

                cb(err, response);
            });
        },

        getContinuousSettings: function getContinuousSettings(name, cb) {
            request.get("/api/continuouswebjobs/" + encodeURIComponent(name) + "/settings", function (err, response) {
                err = err || resolveError(response, "Error getting continuous webjob settings with name '" + name + "'.");
                var data = err
                    ? null
                    : JSON.parse(response.body);

                cb(err, data, response);
            });
        },

        setContinuousSettings: function setContinuousSettings(name, settings, cb) {
            var options = {
                uri: "/api/continuouswebjobs/" + encodeURIComponent(name) + "/settings",
                body: settings,
                json: true
            };

            request.put(options, function (err, response) {
                err = err || resolveError(response, "Error setting continuous webjob settings with name '" + name + "'.");

                cb(err, response);
            });
        }
    };
};
