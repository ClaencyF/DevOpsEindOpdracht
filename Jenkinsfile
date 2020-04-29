pipeline {
    agent {
        docker {
            image 'node:6-alpine' 
            args '-p 3000:3000' 
        }
    }
    stages {
        stage('Init') { 
            steps {
				echo "Installing dependencies."
                sh 'npm install' 
				node --version
            }
        }
		  stage('Build') { 
            steps {
				echo "Building the solution."
                npm run build
            }
        }
    }
}