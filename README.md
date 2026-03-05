# Coding Interview Template

A .NET 10 template project designed to help you quickly set up a workspace for coding interviews and technical assessments. This template provides a clean, pre-configured structure with multiple project types to suit different interview scenarios.

## Project Structure

This solution contains four projects:

- **CodeInterview.WebApi** - An ASP.NET Core Web API project with OpenAPI/Swagger and Scalar API documentation configured for building REST APIs
- **CodeInterview.CLI** - A console application for command-line interface implementations
- **CodeInterview.Business** - A class library for business logic and shared code
- **CodeInterview.Tests** - A test project for unit and integration tests

## Features

- ✅ .NET 10 target framework
- ✅ Web API with OpenAPI/Swagger support
- ✅ Scalar API reference documentation
- ✅ Console application for quick prototyping
- ✅ Separate business logic layer
- ✅ Test project ready to go
- ✅ Clean architecture setup

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### Running the Web API

```bash
dotnet run --project src/CodeInterview.WebApi
```

Navigate to the Swagger UI or Scalar API documentation (available in Development mode).

### Running the CLI

```bash
dotnet run --project src/CodeInterview.CLI
```

### Running Tests

```bash
dotnet test
```

## Usage

This template is designed to be a starting point for:
- Coding interview practice
- Technical assessment preparation
- Quick prototyping and experimentation
- Learning .NET development patterns

Simply clone or fork this repository and start implementing your solutions in the appropriate project based on your needs.