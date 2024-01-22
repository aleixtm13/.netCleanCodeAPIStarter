# Clean Code API Starter Readme

## Table of Contents

1. [Project Overview](#project-overview)
2. [Getting Started](#getting-started)
   - [Prerequisites](#prerequisites)
   - [Installation](#installation)
3. [Usage](#usage)
4. [Authentication and Authorization](#authentication-and-authorization)

## Project Overview

Since you've been off the planet for many years circling the solar system... here's a web api that will allow you to check the environment around you.

## Getting Started

### Prerequisites

1. Have SQL Server installed. Depending on your preferences, OS, etc. 2 options will be proposed:
   1.1 Install directly in your machine. It is available at `https://www.microsoft.com/es-es/sql-server/sql-server-downloads`.
   1.2 Run a docker container from an SQL Server image running the following commands:
   ```shell
   docker pull mcr.microsoft.com/azure-sql-edge
   ```
   ```shell
   docker run -d --name sql_server_mac -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=MyPassword1234!' -p 1433:1433 mcr.microsoft.com/azure-sql-edge
   ```


### Installation

1. Clone the repository to your local machine:

   ```shell
   git clone https://github.com/aleixtm13/solarSystemAPI.git
   ```

2. Navigate to the project directory:

   ```shell
   cd  SolarSystemAPI
   ```

3. Restore project dependencies:

   ```shell
   dotnet restore
   ```

4. Build the project:

   ```shell
   dotnet build
   ```
5. Apply migrations to the DB
   ```shell
   dotnet ef database update -p Infrastructure -s Web.API
   ```

6. Run the API locally:

   ```shell
   dotnet run
   ```

By default, the API will be available at `https://localhost:7232` or `https://localhost:7232` (for HTTPS).


## Usage
To use this API the best option is to open it with swagger tool which is available at `https://localhost:7232/swagger` where you can play and try all the different endpoints.

## Authentication and Authorization
