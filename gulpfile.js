var fs = require('fs');
var glob = require('glob');
var gulp = require('gulp');
var shelljs = require('shelljs');
module.exports = gulp;
var window = {};
var elasticlunr = require('elasticlunr');
var config = require('./Scripts/samplelist');
var beautify = require('json-beautify');
var configJson = JSON.parse(fs.readFileSync('./config.json'));
var publish = require("@syncfusion/ej2-staging/src/publish");
const updateNugetConfig = publish.updateNugetConfig;
var azurePublish = require('@syncfusion/ej2-staging/src/azure-publish');
const aspmvcBuild = azurePublish.aspmvcBuild;
const azureMvcPublish = azurePublish.azureMvcPublish;
var mail = require("@syncfusion/ej2-staging/src/mail");
const publishReportforSamples = mail.publishReportforSamples;

gulp.task("publish-report", publishReportforSamples);
gulp.task("update-nuget-config", updateNugetConfig);
gulp.task("azure-mvc-publish", azureMvcPublish);
gulp.task("aspmvc-build", aspmvcBuild);

gulp.task('deploy', function (done) {
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

gulp.task('generate-searchlist', gulp.series(createLocale, (done) => {
   // console.log(config);
    generateSearchIndex(config.window.samplesList);
    done();
}));

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
        //console.log(url);
        //console.log(i);
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

function adjustTitle(componentName, featureName) {
    const shortTemplates = [
        `Learn about ${featureName} in ASP.NET MVC ${componentName} - Syncfusion Demos`,
        `${featureName} feature in ASP.NET MVC ${componentName} - Try it now!`
    ];

    const longTemplates = [
        `ASP.NET MVC ${componentName} ${featureName} - Syncfusion`,
        `${featureName} Example using ASP.NET MVC ${componentName} - Syncfusion`
    ];

    const base = `ASP.NET MVC ${componentName} ${featureName} Example - Syncfusion Demos`;
    const baseLength = base.length;

    if (baseLength < 50) {
        for (let template of shortTemplates) {
            if (template.length >= 50 && template.length <= 70) {
                return template;
            }
        }
    } else if (baseLength > 70) {
        for (let template of longTemplates) {
            if (template.length >= 50 && template.length <= 70) {
                return template;
            }
        }
    } else {
        return base;
    }
    // If no suitable template found, return the base title with adjustments
    return base.length > 70 ? base.substring(0, 67) + '...' : base.padEnd(50, '.');
}



function adjustDescription(featureName, metaControlCategory) {
    const shortTemplates = [
        `Explore the ${featureName} in ASP.NET MVC ${metaControlCategory}. Learn how it helps improve your app's functionality.`,
        `This example shows how ${featureName} works in ASP.NET MVC ${metaControlCategory}. Understand its purpose and usage.`,
        `Discover the ${featureName} feature in ASP.NET MVC ${metaControlCategory}. Learn how to use it in real-world scenarios.`,
        `Learn how to use ${featureName} in ASP.NET MVC ${metaControlCategory}. This guide helps you integrate it effectively.`,
        `Understand the ${featureName} in ASP.NET MVC ${metaControlCategory}. See how it enhances your development workflow.`,
        `Explore ${featureName} in ASP.NET MVC ${metaControlCategory}. Learn how to configure and apply it in your projects.`
    ];

    const longTemplates = [
        `This example demonstrates the ${featureName} in ASP.NET MVC ${metaControlCategory}. Discover its capabilities, integration steps, and customization options.`,
        `Explore the ${featureName} feature in ASP.NET MVC ${metaControlCategory}. Learn how to use it effectively and integrate it into your application with best practices.`,
        `Understand how ${featureName} works in ASP.NET MVC ${metaControlCategory}. This guide covers usage, configuration, and advanced customization.`,
        `This demo shows how to use ${featureName} in ASP.NET MVC ${metaControlCategory}, including setup, configuration, and real-world implementation tips.`,
        `Discover the benefits of using ${featureName} in ASP.NET MVC ${metaControlCategory}. Learn how to apply it efficiently in your business apps.`,
        `Explore ${featureName} in ASP.NET MVC ${metaControlCategory}. This example covers integration, customization, and practical usage scenarios.`
    ];

    const base = `This example demonstrates the ${featureName} feature in ASP.NET MVC ${metaControlCategory}.Learn how it works and how to integrate it into your application.`

    const baseLength = base.length;

    if (baseLength < 150) {
        for (let template of shortTemplates) {
            if (template.length >= 150 && template.length <= 160) 
                return template;
        }
    } else if (baseLength > 160) {
        for (let template of longTemplates) {
            if (template.length >= 150 && template.length <= 160) 
                return template;
        }
    }
    if(baseLength < 146 && baseLength > 135){
        return base + ' Explore here.';
    }
    if (baseLength < 150 && baseLength > 145) {
        return base + 'Check now.'; 
    } 
    if (baseLength > 160) {
        return base.substring(0, 157) + '...'; 
    }
    return base;
}


gulp.task('title-section', function (done) {
    var samplelists = config.window.samplesList;
    for (let component of samplelists) {
        var samples = component.samples;
        var category = component.category;
        for (let sample of samples) {
            let componentName = component.name;
            let controlCategory = componentName + ' Control';
            let metaControlCategory = componentName + ' control';
            if (category === 'Document Processing Libraries') {
                componentName = component.name + ' library -';
                controlCategory = component.name + ' Library';
                metaControlCategory = component.name + ' library';
            }
            let featureName = sample.name;
            let url = sample.url;
            let dir = sample.component;
            let path = `./Views/${dir}/${url}.cshtml`;
            let content = fs.existsSync(path) ? fs.readFileSync(path, 'utf8') : '';
            var title = adjustTitle(componentName, featureName);
            if(title.length > 70 || title.length < 50) {
                throw new Error(`error: The title for ${featureName} in ${componentName} is not within the recommended length. Please adjust it.`);
            }
            if (content !== '') {
                if ((/@section Title\s?{/).test(content)) {
                    content = content.replace(/@section Title+{([^}]*)}/g, `@section Title{
                    <title>${title}</title> 
                }`).trim();
                } else {
                    content = content + `\n@section Title{
                 <title>${title}</title>
             }`;
                }
                let description = adjustDescription(featureName, metaControlCategory);
                if(description.length > 160 || description.length < 150) {
                   throw new Error(`error: The description for ${featureName} in ${metaControlCategory} is not within the recommended length. Please adjust it.`);
                }
                if ((/@section Meta\s?{/).test(content)) {
                    content = content.replace(/@section Meta+{([^}]*)}/g, `@section Meta{
                    <meta name="description" content="${description}"/>
                }`).trim();
                } else {
                    content = content + `\n@section Meta{
                <meta name="description" content="${description}"/>
            }`;
                }
                let header = `Example of ${featureName} in ASP.NET MVC ${controlCategory}`;
                if ((/@section Header\s?{/).test(content)) {
                    content = content.replace(/@section Header+{([^}]*)}/g, `@section Header{
                    <h1 class='sb-sample-text'>${header}</h1>
                }`).trim();
                } else {
                    content = content + `\n@section Header{
                <h1 class='sb-sample-text'>${header}</h1>
            }`;
                }
                fs.writeFileSync(path, content, 'utf-8');
            }
        }
    }
    done();
});

const SITEMAP_TEMPLATE =
    `<urlset xmlns="http://www.sitemaps.org/schemas/sitemap/0.9">{{:URLS}}
</urlset>`;

const SITE_URL = `
    <url>
        <loc>{{:DemoPath}}</loc>
        <lastmod>{{:Date}}</lastmod>
    </url>`;

const LOCAL_SITE_URL = `
    <url>
        <type>{{:Type}}</type>
        <loc>{{:DemoPath}}</loc>
        <lastmod>{{:Date}}</lastmod>
    </url>`;

gulp.task('sitemap-generate', function (done) {
    let siteMapFile = SITEMAP_TEMPLATE;
    let date = new Date().toISOString().substring(0, 10);
    let link = 'https://ej2.syncfusion.com/aspnetmvc/demos';
    let xmlstring = '';
    let components = config.window.samplesList.map(com => { return { directory: com.directory, type: com.samples.map(list => { return list.type; }), sampleUrls: com.samples.map(samp => { return samp.url; }) }; });
    for (let component of components ? components : []) {
        let sampleUrls = component.sampleUrls;
        let sampleType = component.type;
        sampleUrls = sampleUrls ? sampleUrls : [];
        sampleType = sampleType ? sampleType : [];
        for (let i = 0; i < sampleUrls.length; i++) {
            let urls = SITE_URL;
            if (process.argv[4] === 'local-sitemap' && sampleType[i] === 'new') {
                urls = LOCAL_SITE_URL;
                urls = urls.replace(/{{:Type}}/g, 'new');
            }
            urls = urls.replace(/{{:DemoPath}}/g, `${link}/${component.directory.toLowerCase()}/${sampleUrls[i].toLowerCase()}`);
            urls = urls.replace(/{{:Date}}/g, date);
            xmlstring += urls;
        }
    }
    siteMapFile = siteMapFile.replace(/{{:URLS}}/g, xmlstring);
    if (process.argv[4] === 'local-sitemap') {
        fs.writeFileSync('./' + configJson.appName + '/sitemap-demos.xml', siteMapFile, 'utf-8');
    } else {
        fs.writeFileSync('./sitemap-demos.xml', siteMapFile, 'utf-8');
    }
    done();
});

gulp.task('mvc-version-update', function (done) {
    var packageConfig = fs.readFileSync('./packages.config', 'utf-8');
    var csprojMvc = fs.readFileSync('./EJ2MVCSampleBrowser.csproj', 'utf-8');
    var packageList = packageConfig.match(/<package.*id.*=.*"Syncfusion.*"/g);
    var nexusFeed = fs.readFileSync('./NuGet.config', 'utf8');
    nexusFeed = nexusFeed.match(/key="NexusServer" value=".*\/"/)[0].split('value=')[1];
    if (packageList) {
        for (var nuget of packageList) {
            var nugetName = nuget.split(' version')[0].replace('<package id="', '').replace('"', '');
            if (!(/Syncfusion.EJ2.MVC5|Syncfusion.EJ2.GridExport.MVC5|Syncfusion.Licensing/.test(nugetName))) {
                var shellCode = shelljs.exec(`nuget list ${nugetName} -AllVersions -Source ${nexusFeed}`, { silent: true, async: false });
                if (shellCode.code === 0 && !shellCode.stdout.startsWith('No packages found.')) {
                    console.log("Package name -> " + nugetName + " ;");
                    var versionLists = shellCode.stdout.match(new RegExp(`${nugetName} 100.2.(.*)`, 'g')).map(output => { return output.replace(`${nugetName} `, '') });
                    versionLists = versionLists.sort((a, b) => b.localeCompare(a));
                    var startVersion = 0; var endVersion = [];
                    for (var versionList of versionLists) {
                        var splitVersion = versionList.split('.');
                        var prefixVersion = splitVersion[0] + '.' + splitVersion[1];
                        var middleVersion = splitVersion[2];
                        var suffixVersion = (splitVersion[2] === undefined || null) ? '0' : splitVersion[2];
                        if (parseFloat(prefixVersion) > startVersion) {
                            startVersion = parseFloat(prefixVersion);
                            endVersion = [];
                            endVersion.push(parseFloat(suffixVersion));
                        } else if (parseFloat(prefixVersion) === startVersion) {
                            endVersion.push(parseFloat(suffixVersion));
                        } else if (parseFloat(prefixVersion) < startVersion) {
                            break;
                        }
                    }
                    var version = endVersion.sort(function (a, b) { return b - a; })[0];
                    //version = `${startVersion}.${middleVersion}.${version}`;
                    version = `100.2.${version}`;
                    console.log("Package name -> " + nugetName + " ; Version -> " + version);

                    // Version changing for packages.config file.
                    var updatedNuget = nuget.replace(/version=".*"/g, `version="${version}"`)
                    packageConfig = packageConfig.replace(nuget, updatedNuget);

                    // Version changing for MVC4 and MVC5 project file.
                    csprojMvc = csprojMvc.replace(new RegExp(`packages\\\\${nugetName}.*\\\\lib`), `packages\\${nugetName}.${version}\\lib`);
                } else if (shellCode.code !== 0) {
                    if ((shellCode.stderr).indexOf("'nuget' is not recognized") >= 0 || (shellCode.stderr).indexOf("nuget: not found") >= 0 ) {
                        shelljs.cp('./node_modules/@syncfusion/ej2-staging/nuget.exe', './')
                        shelljs.exec("gulp mvc-version-update");
                    }
                    else {
                        done();
                        console.log(" ERROR -> " + shellCode.stderr + " ;");
                        process.exit(1);
                    }
                }
            }
        }
        fs.writeFileSync('./packages.config', packageConfig);
        fs.writeFileSync('./EJ2MVCSampleBrowser.csproj', csprojMvc);
    }
    done();
});


gulp.task('code-leaks-analysis', function (done) {
    var codeLeaksReport = JSON.parse(fs.readFileSync('GitLeaksReport.json', 'utf-8'));
    if (Object(codeLeaksReport).length <= 0) {
        console.log("<- No Leaks Found ->");
        shelljs.exec('rm GitLeaksReport.json')
    }
    else {
        throw "Please clear the Git Leaks reported issues";
    }
    done();
});