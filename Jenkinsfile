pipeline {
 agent any


 stages{
  stage('Init'){
   steps{
     sh 'echo "Starting initalize phase"
	 sh 'npm install'
    
	 sh' echo "Initialize Succesfull"'
   }
      
  stage('Build'){
   steps{
    
    echo "Starting build ...."
    sh 'ng build --aot --prod'
    println "Build Success.."
   }
 
}
}