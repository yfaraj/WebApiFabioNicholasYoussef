The solution is hosted in GitHub:
https://github.com/yfaraj/WebApiFabioNicholasYoussef

Installation Process:
1 - Access the GitHub repo above and clone it locally
2 - Please make sure muiltiple startup project are set including the following projects: 
    - WebSite
    - WebAPI_1
    - WebAPI_2
    - WebAPI_3
    - WebAPI_4
3 - Build the solution so all project get a fresh built
4 - Run in Debug mode and so you can test as you wish. If you get any IIS problem, or any other issue that block you from test the system, please delete all obj and bin folders and then Build again. It should solve the problem.

The solution contains 6 projects:
1. CommonStructures
This project contains shared data structures

2. WebAPI_1
This project provides the 1st API which will add ManufacturerRecallNumber, and provide read and search.
This project is done by yfaraj@hotmail.co.uk

3. WebAPI_2
This project provides the 2nd API which will add CategoryETXT and CategoryFTXT, and provide read and search.
This project is done by yfaraj@hotmail.co.uk

4. WebAPI_3
This project provides the 3rd API which will add SystemTypeETXT and SystemTypeFTXT, and provide read and search.
This project is done by fabiopereira.ca@gmail.com

5. WebAPI_4
This project provides the 3rd API which will add NotificationTypeETXT and NotificationTypeFTXT, and provide read and search.
This project is done by nicholas.luong6@gmail.com

6. WebSite
This project provides a user interface that allows the end-user to interact with the functionalities of all of the above 4 APIs.
This project is done by fabiopereira.ca@gmail.com

Software needed to compile and build the project:
1. Microsoft Windows 10 + operating system
2. Microsoft Visual Studio 2022 Community Edition from https://visualstudio.microsoft.com/vs/community/
3. Download and install the latest version of "ASP.NET Core Runtime 3.1" from https://dotnet.microsoft.com/en-us/download/dotnet/3.1
4. download and install Git from https://git-scm.com/downloads

Testing Steps:
1. git clone https://github.com/yfaraj/WebApiFabioNicholasYoussef.git
2. Navigate the root folder "WebApiFabioNicholasYoussef"
3. Navigate to directory "\WebApiFabioNicholasYoussef\WebAPI_1\bin\Release\netcoreapp3.1\" and double-click the executable file "WebAPI_1.exe" to start API 1
4. Navigate to directory "\WebApiFabioNicholasYoussef\WebAPI_2\bin\Release\netcoreapp3.1\" and double-click the executable file "WebAPI_2.exe" to start API 2
5. Navigate to directory "\WebApiFabioNicholasYoussef\WebAPI_3\bin\Release\netcoreapp3.1\" and double-click the executable file "WebAPI_3.exe" to start API 3
6. Navigate to directory "\WebApiFabioNicholasYoussef\WebAPI_4\bin\Release\netcoreapp3.1\" and double-click the executable file "WebAPI_4.exe" to start API 4
7. Host the WebSite project on the cloud or a dedicated web server

