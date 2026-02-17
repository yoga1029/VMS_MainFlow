pipeline {

    agent any

    environment {
        DOTNET_SOLUTION = 'VMS_MainFlow.sln'
        EMAIL_FROM = 'scheduledautomationtrigger@gmail.com'
        EMAIL_TO = 'yogeswari@riota.in,bhavyashree@riota.in,sujitganeash@riota.in'
    }

    stages {

        stage('Run Tests') {
            steps {
                echo "Running MSTest tests on solution ${env.DOTNET_SOLUTION}"

                catchError(buildResult: 'UNSTABLE', stageResult: 'UNSTABLE') {
                    bat """
                    if exist TestResults rmdir /s /q TestResults
                    dotnet test ${env.DOTNET_SOLUTION} ^
                    --logger trx ^
  	            --logger "console;verbosity=detailed" ^
                    --results-directory TestResults
                    """
                }
            }
        }
    }

    post {
        always {
            echo 'Publishing MSTest results to Jenkins'
            bat 'dir /s *.trx'
            mstest testResultsFile: '**/TestResults/*.trx'

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