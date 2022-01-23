#Experiment with Logging - C#


Right click on the project name, and choose “Manage NuGet Packages…”:
![image](https://user-images.githubusercontent.com/70380850/150652394-5e690c02-8278-4ae5-85db-03720c1c4297.png)



Choose “Browse” and install “log4net”
![image](https://user-images.githubusercontent.com/70380850/150652401-1942d687-50f4-4cf2-9eae-bcae39256026.png)


Expand “Properties” and enter “AssemblyInfo.cs” and add that:
![image](https://user-images.githubusercontent.com/70380850/150652412-2cf489bb-acc9-445a-8e8d-cd9c6f2527bc.png)


Enter “App.config” and paste that between the configuration and startup :
![image](https://user-images.githubusercontent.com/70380850/150652417-1a609355-d796-4666-843d-d5c84286f7d5.png)


  
Program.cs :

![image](https://user-images.githubusercontent.com/70380850/150652420-3d9a2cb5-bf73-40c8-8aba-d0803d69c95a.png)

Log file:
![image](https://user-images.githubusercontent.com/70380850/150652434-0d02922c-f8ed-43e7-b4a1-04b7ee4b01fd.png)

Creating an exception: (and “catch” the Log.Error exception): 
![image](https://user-images.githubusercontent.com/70380850/150652445-b383df9e-a6cb-4545-a8ed-6b5f16bed70a.png)



Inside the log file:
![image](https://user-images.githubusercontent.com/70380850/150652457-36087b0a-a1e6-41d7-84c3-18a6f63c33c1.png)
