## About The Project

**Note**: This project is a non-commercial application based on authors personal interests of technologies.

This project represents application that is responsible for handling users and related to them entities.

### Built With

* [C# 12](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12);
* [ASP.Net 8.0 WebAPI](https://docs.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-8.0?view=aspnetcore-8.0);
* [Entity Framework](https://entityframeworkcore.com);
* [Identity Server Core](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-8.0);
* [Handlebars](https://handlebarsjs.com/);
* [Automapper](https://automapper.org/);
* [MailKit](https://github.com/jstedfast/MailKit);
* [HealthChecks UI](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/monitor-app-health);
* [NUnit](https://nunit.org/);

### Prerequisites

Before launching this application make sure you have prepared the following components:

* Windows | macOS | Linux;
* [MSSQL](https://www.microsoft.com/en-us/sql-server/sql-server-2019?rtc=1);
* [.Net 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0);
* [Visual Studio](https://visualstudio.microsoft.com/) | [Visual Studio Code](https://code.visualstudio.com/) | [Rider](https://www.jetbrains.com/rider/);
* [SSMS](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15) | [DBeaver](https://dbeaver.io/) | [DataGrip](https://www.jetbrains.com/datagrip/);
* [Docker](https://www.docker.com) | [Rancher Desktop](https://rancherdesktop.io/) | [Podman](https://podman.io/) - Optional;

### Installation and launch

1. Clone repository
2. Execute the following command to configure git hooks for repository: `git config --local core.hooksPath .githooks/`. If you use Linux/MacOS, make sure you have enough permissions to run hooks, execute the following command: `sudo chmod +x .githooks/*`.
3. Run **IdentityWebApi.sln** in the root directory;
4. Depending on your OS, choose IIS or Kestrel as hosting webserver;
5. Make sure your MSSQL database instance is running. Otherwise you will not be able to launch app;
6. Start the application;
7. Visit the following URL: `https://localhost:{port}/swagger`. You should be able to see Swagger description;

### Docker launch

Docker is not necessary to launch application if you have prepared prerequisites for your physical OS. If you want to launch it without and modifications and would like to see the working result, you can refer to the next steps:

1. Follow the first step from previous article;
2. Switch open project root directory via terminal;
3. Run the following command:
    ```
    docker-compose up --build
    ```
4. Wait until corresponding images will be downloaded, all steps from Dockerfile will pass and application will start;
5. Visit the following URL: http://localhost:13501/swagger. You should be able to see Swagger description;
6. If you need to stop Docker containers, you can just press `ctrl + C` keyboard combination in your terminal and wait until containers will be stopped. To terminate containers, enter (or stop via Docker dashboard):
    ```
    docker-compose down
    ```
7. To remove application images, enter the following command (or remove via Docker dashboard):
    ```
    docker rmi mcr.microsoft.com/mssql/server identitywebapi
    ```

## Logging
Application doesn't writes logs to files, it display logs in terminal in the following ways:
1. Local run via IDE;
2. Docker;

## Usage

For more examples, please, refer to the following options:
* [Swagger](https://swagger.io/)