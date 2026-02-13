pipeline {
    agent any

    environment {
        DOTNET_SOLUTION = 'GIT_VMS-Phase1PortalAT.sln'
        EMAIL_FROM = 'scheduledautomationtrigger@gmail.com'
        EMAIL_TO ='yogeswari@riota.in'
    }

    stages {
        stage('Checkout') {
            steps {
                echo 'Code downloaded from GitHub'
            }
        }

           stage('Run Tests') {
            steps {
                echo "Running MSTest tests on solution ${env.DOTNET_SOLUTION}"

                // Allow pipeline to continue even if tests fail
                catchError(buildResult: 'UNSTABLE', stageResult: 'UNSTABLE') {
                  bat """
                dotnet test ${env.DOTNET_SOLUTION} --logger "console;verbosity=detailed"
                """
                }
            }
        }
    }

    post {
        always {
            echo 'Publishing MSTest results to Jenkins'

            // Always publish results (pass or fail)
            mstest testResultsFile: '**/test_results.trx'

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