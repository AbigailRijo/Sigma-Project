pipeline {
    agent any
    stages {
        stage ('Build') {
             steps {
                 powershell script: 'C:\\PipelineScripts\\buildScript.ps1'
            }
        }
        stage ('publish') {
             steps {
                 powershell script: 'C:\\PipelineScripts\\publishScript.ps1'
            }
        }
        stage ('Compress Files') {
             steps {
                 powershell script: 'C:\\PipelineScripts\\compressFilesScript.ps1'
            }
        }
        stage ('Copy Files To temporal folder in Remote Server') {
             steps {
                 powershell script: 'C:\\PipelineScripts\\copyFilesToTempDestinationOfRemoteServerScript.ps1'
            }
        }
        stage ('Stop WebSite in Remote Server') {
             steps {
                 powershell script: 'C:\\PipelineScripts\\stopWebSiteScript.ps1'
            }
        }
        stage ('Copy Files To final folder in Remote Server') {
             steps {
                 powershell script: 'C:\\PipelineScripts\\copyFilesToFinalDestinationOfRemoteServerScript.ps1'
            }
        }
        stage ('Start WebSite in Remote Server') {
             steps {
                 powershell script: 'C:\\PipelineScripts\\startWebSiteScript.ps1'
            }
        }
    }
    post {
        always {
            echo 'This will always run'
        }
        success {
            echo 'This will run only if successful'
        }
        failure {
            echo 'This will run only if failed'
        }
        unstable {
            echo 'This will run only if the run was marked as unstable'
        }
        changed {
            echo 'This will run only if the state of the Pipeline has changed'
            echo 'For example, if the Pipeline was previously failing but is now successful'
        }
    }
}
