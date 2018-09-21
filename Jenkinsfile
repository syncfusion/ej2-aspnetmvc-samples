#!groovy

node('EJ2Samples') {
    try {
        deleteDir();
        stage('Checkout') {
            checkout scm
        }

        stage('Install') {
            runShell('npm -v');
            runShell('npm install');
            runShell('git config --global user.email "essentialjs2@syncfusion.com"');
            runShell('git config --global user.name "essentialjs2"');
            runShell('git config --global core.longpaths true');
        }

        stage('Build') {
            runShell('nuget locals all -Clear')
            runShell('nuget restore');
            runShell('msbuild /verbosity:m ./EJ2MVCSampleBrowser.csproj');
        }

        stage('Publish') {
            if(env.BRANCH_NAME == 'development' || env.BRANCH_NAME == 'master') {
                def appPath = env.BRANCH_NAME == 'master' ? 'ej2aspmvc' : 'ej2aspmvcapp';
                runShell('npm run deploy');
            }
        }
    }
    catch(Exception e) {
        shared.throwError(e);
        deleteDir();
    }
}

def runShell(String command) {
    if(isUnix()) {
        sh command;
    }
    else {
        bat command;
    }
}
