var fs = require('fs');
var glob = require('glob');
var gulp = require('gulp');
var shelljs = require('shelljs');
module.exports = gulp;
var window = {};
var elasticlunr = require('elasticlunr');
var config = require('./Scripts/samplelist');
var beautify = require('json-beautify');
require("@syncfusion/ej2-staging");

gulp.task('deploy', function(done) {
    // remove clone folder
    shelljs.rm('-rf', './ej2aspmvc');
    var commitMessage = shelljs.exec('git log -1 --pretty=%B').stdout.trim();
    console.log('COMMIT MESSAGE: ' + commitMessage);
    // create clone directory
    fs.mkdirSync('./ej2aspmvc');
    // navigate to clone location
    shelljs.cd('./ej2aspmvc');
    var appPath = process.env.BRANCH_NAME == 'master' ? 'ej2aspmvc' : 'ej2aspnetmvc';
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

gulp.task('generate-searchlist',["create-locale"], function () {
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

        var component = sampleCollection.directory;
        var directory = sampleCollection.directory;
        var puid = sampleCollection.uid;
        var hideOnDevice = sampleCollection.hideOnDevice;
        for (sample of sampleCollection.samples) {
            sample.component = component;
            sample.dir = directory;
            sample.parentId = puid;
            sample.hideOnDevice = hideOnDevice;
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
        if (component === data[i].directory) {
            return data[i];
        }
    }
}
gulp.task('create-locale', function (done) {
    createLocale(done);
});

function createLocale(done) {
    var fileExt = '.js';
    var localePath = './Scripts';
    if (!fs.existsSync(localePath)) {
        shelljs.mkdir('-p', localePath);
    }
    var localeJson = glob.sync('./Views/**/locale.json', {
        silent: true
    });
    if (localeJson.length) {
        // baseUtil;
        var obj = {};
        for (var i = 0; i < localeJson.length; i++) {
            var compentLocale = JSON.parse(fs.readFileSync(localeJson[i]));
            obj = extend({}, obj, compentLocale, true);
        }
        fs.writeFileSync(`${localePath}/locale-string${fileExt}`,
            'window.Locale=' + JSON.stringify(obj) + ';');
        done();
    } else {
        fs.writeFileSync(`${localePath}/locale-string${fileExt}`,
            'window.Locale={}');
        done();
    }
}
function extend(copied, first, second, deep) {
    var result = copied || {};
    var length = arguments.length;
    if (deep) {
        length = length - 1;
    }
    var _loop_1 = function (i) {
        if (!arguments_1[i]) {
            return 'continue';
        }
        var obj1 = arguments_1[i];
        Object.keys(obj1).forEach(function (key) {
            var src = result[key];
            var copy = obj1[key];
            var clone;
            if (deep && isObject(copy)) {
                clone = isObject(src) ? src : {};
                result[key] = extend({}, clone, copy, true);
            }
            else {
                result[key] = copy;
            }
        });
    };
    var arguments_1 = arguments;
    for (var i = 1; i < length; i++) {
        _loop_1(i);
    }
    return result;
}

function isObject(obj) {
    var objCon = {};
    return (!isNullOrUndefined(obj) && obj.constructor === objCon.constructor);
}
function isNullOrUndefined(value) {
    return value === undefined || value === null;
}

gulp.task('desValidation', function (done) {
    var files = glob.sync('./Views/*/*', {
        silent: true,
        ignore: [
            './Views/Shared/*', './Views/**/locale.json', './Views/**/fonts', './Views/**/icons', './Views/**/Index.cshtml', './Views/Grid/_DialogAddPartial.cshtml', './Views/Grid/_DialogEditPartial.cshtml'
        ]
    });
    var reg = /.*meta name([\S\s]*?)\/.*/g;
    var reg1 = /\"([^"]+)\"/g;
    var error = "";
    var des = "";
    for (var i = 573; i < files.length; i++) {
        var url = files[i].split('/')[2] + '/' + files[i].split('/')[3];
        var cshtml = fs.readFileSync(files[i], 'utf8');
         console.log(url);
         console.log(i);
        if (reg.test(cshtml)) {
            cshtml = cshtml.match(reg)[0].match(reg1)[1].replace(/"/g, "");
            if (!(cshtml.length >= 100) && (cshtml.length <= 160)) {
                error = error + url + ' description length should be between 100 to 160 characters\n';
            }
        } else {
            des = des + url + ' description needed\n';
        }
    }
    if (error || des) {
        if (!fs.existsSync('./cireports')) {
            fs.mkdirSync('./cireports');
            
        }
        fs.writeFileSync('./cireports/descriptionValidation.txt', error + des, 'utf-8');
        done();
    }
});

gulp.task('title-section', function () {
    var samplelists = config.window.samplesList;
    for (let component of samplelists) {
        var samples = component.samples;
        for(let sample of samples){
            let componentName = component.name;
            let featureName = sample.name;
            let url = sample.url;
            let dir = sample.component; 
            let path = `./Views/${dir}/${url}.cshtml`;
            let content = fs.existsSync(path) ? fs.readFileSync(path, 'utf8') : '';
            let title = `ASP.NET MVC ${componentName} ${featureName} Example - Syncfusion Demos `;
            if(content !== ''){
            if(content.includes('@section Title{')){
                content = content.replace(/@section Title+{([^}]*)}/g, `@section Title{
                    <title>${title}</title> 
                }`).trim();
            }else {
             content = content + `\n@section Title{
                 <title>${title}</title>
             }`;
            }
            let description = `This example demonstrates the ${featureName} in ASP.NET MVC ${componentName} control. Explore here for more details.`;
            if(content.includes('@section Meta{')){
                content = content.replace(/@section Meta+{([^}]*)}/g, `@section Meta{
                    <meta name="description" content="${description}"/>
                }`).trim();
            }else{
            content = content + `\n@section Meta{
                <meta name="description" content="${description}"/>
            }`;
        }
            let header = `Example of ${featureName} in ASP.NET MVC ${componentName} Control`;
            if(content.includes('@section Header{')){
                content = content.replace(/@section Header+{([^}]*)}/g, `@section Header{
                    <h1 class='sb-sample-text'>${header}</h1>
                }`).trim();
            }else{
            content = content + `\n@section Header{
                <h1 class='sb-sample-text'>${header}</h1>
            }`;
        }
             fs.writeFileSync(path, content, 'utf-8');
    }
        }
    }
});
