pipeline {
    agent any

    environment {
        DOTNET_SOLUTION = 'VMS_MainFlow.sln'
        EMAIL_FROM = 'scheduledautomationtrigger@gmail.com'
        EMAIL_TO ='yogeswari@riota.in'
    }

    stages {
        stage('Run Tests') {
            steps {
                echo "Running MSTest tests on solution ${env.DOTNET_SOLUTION}"

                catchError(buildResult: 'UNSTABLE', stageResult: 'UNSTABLE') {
                    bat """
                    dotnet test ${env.DOTNET_SOLUTION} --logger "trx"
                    """
                }
            }
        }
    }

    post {
        always {
            echo 'Publishing MSTest results to Jenkins'

            mstest testResultsFile: '**/*.trx'

            echo "Sending email with test counts"

            emailext(
                from: "${env.EMAIL_FROM}",
                subject: "Cloud Flow Automation Report - Build #${env.BUILD_NUMBER} - ${currentBuild.currentResult}",
                mimeType: 'text/html',
                body: '${SCRIPT, template="groovy-html.template"}',
                to: "${env.EMAIL_TO}",
                attachLog: false
            )
        }
    }
}