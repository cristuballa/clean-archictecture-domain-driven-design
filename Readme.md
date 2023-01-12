# REST API Application

This is a sample REST API application written in .NET 7 and C# that demonstrates a clean architecture and Domain-Driven Design principles. The application includes features such as:

## Features

- **Authentication and Authorization** using JSON Web Tokens (JWT)
- **API documentation** using Swagger
- **Logging** using Serilog
- **Caching** using MemoryCache
- **API versioning**
- **Repository pattern**
- **Global error handling**
- **Command-Query Responsibility Segregation (CQRS)** using MediatR
- **Object-to-object mapping** using Mapster
- **Validation** using FluentValidation
- **Data access** using EF Core

## Clean Architecture

The application follows the Clean Architecture principles as outlined by Robert C. Martin. This architecture is centered around the use of a Domain Model, which defines the business rules of the application, and is completely independent of any external concerns such as data access or presentation.

## Domain-Driven Design

The application also makes use of Domain-Driven Design principles, which focus on the modeling of the business domain in the application. This includes the use of entities, value objects, and aggregates to represent the concepts in the domain.

## Setup

To get started, clone the repository and run the `dotnet restore` command to install the necessary dependencies. Then, update the `appsettings.json` file with your database connection string and run the `dotnet ef database update` command to create the necessary tables. Finally, start the application using the `dotnet run` command.
