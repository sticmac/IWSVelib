# IWSVelib
Intermediary SOAP Web Service for the REST JCDecaux API. Lab for Web Services and Oriented Computing course at Polytech Nice Sophia.

## Chosen extensions
* GUI application (2 points)
* ASP .Net Core Docker deployment (8 points)

## Instructions

As a first step before running any of the programs available, please generate the whole solution through Visual Studio (tested with Visual Studio 2017 Community Edition).

### MVP

1. Run the `IWSVelibLib` project (`IWSVelib` sub-folder). This runs our SOAP middleware service as a WCF service in the background.
2. Run the `VelibClient` project. This runs a client console to communicate with the middleware service. You can take knowledge of the different available commands and their usage through the `help` command once the CLI is launched.

### GUI extension

1. As for the MVP, please run the `IWSVelibLib` project (`IWSVelib` sub-folder). Then, the SOAP middleware can run in the background.
2. Run the `VelibClientGUI` project. This runs a graphical client where you have to choose a city in those listed on the left, then a station available for that city (the list automatically updates). It then displays the number of available bikes on the right side of the client.

### Docker Deployment extension

1. You need to run the `docker-compose` build plan. Two ways to do it:
    1. You can run it through Visual Studio as you'd run any other project (with the Release option).
    2. You can run it directly with powershell by going to the solution directory and run the `docker-compose up` command.      
    
    This runs the SOAP middleware into a ASP .Net core project (`IWSVelibCore` project) instead of a WCF one. The whole is run into a docker container, so it can be easily deployed.
  
2. Run the `VelibClientDotNetCore` project (`VelibClientDocker` subfolder). It runs a client very similar to the MVP one, but tries to connect to the docker container instead of the normal WCF service.
