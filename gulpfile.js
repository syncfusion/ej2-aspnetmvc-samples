var fs = require('fs');
var glob = require('glob');
var gulp = require('gulp');
var shelljs = require('shelljs');
module.exports = gulp;
var window = {};
var elasticlunr = require('elasticlunr');
var config = require('./scripts/samplelist.js');
var beautify = require('json-beautify');

gulp.task('deploy', function(done) {
    // remove clone folder
    shelljs.rm('-rf', './ej2aspmvc');
    var commitMessage = shelljs.exec('git log -1 --pretty=%B').stdout.trim();
    console.log('COMMIT MESSAGE: ' + commitMessage);
    // create clone directory
    fs.mkdirSync('./ej2aspmvc');
    // navigate to clone location
    shelljs.cd('./ej2aspmvc');
    var appPath = process.env.BRANCH_NAME == 'master' ? 'ej2aspmvc' : 'ej2aspmvcapp';
    // get git url for pull the repository
    var remotePath = 'https://' + process.env.EJ2_AZURE_CRED + '@' + appPath + '.scm.azurewebsites.net:443/' + appPath + '.git';
    shelljs.exec('git init && git fetch ' + remotePath + ' master && git checkout master');
    shelljs.exec('git pull ' + remotePath + ' master');

    // get the removable files and remove it from cloned git repo
    var rmFiles = glob.sync('./**/*', { ignore: ['./', './.git/**'] });
    shelljs.rm('-rf', rmFiles);
    // navigate to root folder
    shelljs.cd('../');

    // copy files from root to cloned location
    var files = glob.sync('{./**/*,./*,./.deployment}', { ignore: ['./', './ej2aspmvc/', './ej2aspmvc/**', './packages/**', './bin/**', './obj/**', './node_modules/**', './gulpfile.js', './package.json', './package-lock.json'] })
    var sourceFiles = [];
    for (var i = 0; i < files.length; i++) {
        if (fs.lstatSync(files[i]).isDirectory() && files[i].split('/').length <= 2) {
            sourceFiles.push(files[i] + '/');
        } else if (files[i].split('/').length <= 2) {
            sourceFiles.push(files[i]);
        }
    }
    shelljs.cp('-R', sourceFiles, './ej2aspmvc/');

    // navigate to cloned location
    shelljs.cd('./ej2aspmvc');
    // git add remote, add files and commit
    shelljs.exec('git remote add master ' + remotePath);
    shelljs.exec('git add . && git commit -m "' + commitMessage + '"');
    // git push changes to remote repo
    var deploy = shelljs.exec('git push ' + remotePath + ' master:master', { silent: false });
    // navigate to roor folder
    shelljs.cd('../');
    if (deploy.code !== 0) {
        console.log(deploy.stderr);
        done();
        process.exit(1);
    } else {
        console.log('Deployed Successfully!!!');
        done();
    }
});

gulp.task('generate-searchlist', function () {
    console.log(config);
    generateSearchIndex(config.window.samplesList);
});

function generateSearchIndex(data) {

    var result = [];
    var updatedList;
    var subCategory = [];
    var intId = 0;
    var addUID = function (pid, dt) {
        for (var i = 0; i < dt.length; i++) {
            dt[i].uid = pid + i;
            if (dt[i].hasOwnProperty('samples')) {
                curDirectory = dt[i].directory;
                subCategory = [];
                addUID('00' + intId + i, dt[i].samples);
                intId++;
                var isLast = intId === dt.length - 1;
            } else {
                var index = subCategory.indexOf(dt[i].category);
                if (index !== -1) {
                    dt[i].order = index;
                } else {
                    subCategory.push(dt[i].category);
                    dt[i].order = subCategory.length - 1;
                }
            }
        }
        updatedList = dt;
    }
    var sampleOrder = JSON.parse(fs.readFileSync('./Scripts/sampleOrder.json', 'utf8'));
    var orderKeys = Object.keys(sampleOrder);
    for (var i = 0; i < orderKeys.length; i++) {
        var components = sampleOrder[orderKeys[i]];
        for (var j = 0; j < components.length; j++) {
            var currentData = getSamples(data, components[j]);
            currentData['order'] = i;
            result.push(currentData);
        }
    }
    addUID("0", result);
    elasticlunr.clearStopWords();
    var instance = elasticlunr(function () {
        this.addField('component');
        this.addField('name');
        this.setRef('uid');
    });
    for (sampleCollection of data) {

        var component = sampleCollection.name;
        var directory = sampleCollection.directory;
        var puid = sampleCollection.uid;
        for (sample of sampleCollection.samples) {
            sample.component = component;
            sample.dir = directory;
            sample.parentId = puid;
            instance.addDoc(sample);
        }
    }
    var string = `if (!window) {

        var window = exports.window = {};
    }
    window.samplesList =`;

    fs.writeFileSync('./Scripts/samplelist.js', string + beautify(updatedList, null, 2, 100));
    fs.writeFileSync('./Scripts/search-index.js', 'window.searchIndex = ' + JSON.stringify(instance.toJSON()));
}
function getSamples(data, component) {
    for (var i = 0; i < data.length; i++) {
        if (component === data[i].name) {
            return data[i];
        }
    }
}