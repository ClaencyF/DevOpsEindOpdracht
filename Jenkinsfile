pipeline {
    agent {
        docker {
            image 'node:14.0.0-alpine3.11' 
            args '-p 3000:3000' 
        }
    }
	
	environment {
        CI = 'true' 
    }

    stages {
        stage('Init') { 
            steps {
				echo "Installing dependencies."
               
            }
        }
		  stage('Build') { 
            steps {
				echo "Building the solution."
               
            }
        }
		
		 stage('Testing') { 
            steps {
				echo "Testing the solution."
				sh 'npm prune'
				// sh 'npm test --watchAll=false'
            }
		}
	}
	
	
	 post {  

         success {  
             mail bcc: '', body: "<b>Build Successfull.</b><br>Project: ${env.JOB_NAME} <br>Build Number: ${env.BUILD_NUMBER} <br> URL de build: ${env.BUILD_URL}", cc: '', charset: 'UTF-8', from: '', mimeType: 'text/html', replyTo: '', subject: "ERROR CI: Project name -> ${env.JOB_NAME}", to: "ClaencyJenkins@gmail.com";
         }  
         failure {  
             mail bcc: '', body: "<b>Build Unsuccesfull.</b><br>Project: ${env.JOB_NAME} <br>Build Number: ${env.BUILD_NUMBER} <br> URL de build: ${env.BUILD_URL}", cc: '', charset: 'UTF-8', from: '', mimeType: 'text/html', replyTo: '', subject: "ERROR CI: Project name -> ${env.JOB_NAME}", to: "ClaencyJenkins@gmail.com";  
         }  
        
     }  
}