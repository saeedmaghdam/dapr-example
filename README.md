# dapr-example

## Install

**Install Docker Desktop**
[https://docs.docker.com/desktop/install/windows-install/](https://docs.docker.com/desktop/install/windows-install/)

**Install Dapr from following repository**
[https://github.com/dapr/cli/releases](https://github.com/dapr/cli/releases)

**Initialize Dapr in local environment**
```dapr init```

**Install tye**
[https://github.com/dotnet/tye/blob/main/docs/getting_started.md](https://github.com/dotnet/tye/blob/main/docs/getting_started.md)

## Running

**Method One**
Run using docker compose, from inside visual studio or command line

**Method Two**
```tye run```
And access the dashboard from [http://localhost:8000/](http://localhost:8000/)

**Running Cli Application**
```dapr run --app-id DaprCounter dotnet run```

**Access Data Inside Redis Database**
Add a new connection in Another Redis Desktop Manager, set host to localhost, port to 6379, and skip setting user and password

## Debugging
In order to debug the services, simply open the project in visual studio and attach the running process using Debug menu in visual studio.

## Resource
[Getting Started with Dapr for .Net Developers](https://learn.microsoft.com/en-us/dotnet/architecture/dapr-for-net-developers/getting-started)
