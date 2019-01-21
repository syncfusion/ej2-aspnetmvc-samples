#!groovy

node('EJ2Samples') {
    try {
        deleteDir();
        stage('Import') {
            git url: 'https://gitlab.syncfusion.com/essential-studio/ej2-groovy-scripts.git', branch: 'master', credentialsId: env.JENKINS_CREDENTIAL_ID;
            shared = load 'src/shared.groovy';
        }

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
            runShell('nuget locals all -Clear');
            runShell('npm run build');
            runShell('gulp aspmvc-build --option ./EJ2MVCSampleBrowser.csproj')
        }

        stage('Publish') {
            if(shared.isProtectedBranch()) {
                runShell('npm run publish');
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
