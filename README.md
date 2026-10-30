# SVLaixe

SVLaixe is a modern ASP.NET Core application designed to support educational assessment workflows by managing exam questions, answers, explanations, categories, and submission logic.

## Overview

SVLaixe is built to provide a clean and maintainable backend for interactive learning and assessment systems. The application exposes RESTful APIs for managing exam content and evaluating user responses efficiently.

The solution is intended to support:
- Question and category management
- Answer and explanation retrieval
- Dynamic question generation
- Exam result calculation
- API-based validation of assessment data

## Features

- Manage questions, answers, explanations, and categories
- Load structured content from JSON files
- Generate random questions for assessments
- Calculate exam scores and results
- Expose RESTful endpoints for reading and validating data
- Use a repository-based architecture for maintainability
- Support dependency injection and modular application design
- Build on modern ASP.NET Core practices

## Technologies

SVLaixe is developed using the following technologies and frameworks:

- .NET 8
- C# 12
- ASP.NET Core
- Blazor
- RESTful API development with Controllers
- Repository pattern
- Dapper
- JSON-based data seeding/import
- Dependency injection
- Swagger / OpenAPI support (when enabled)

## Project Goals

The primary goal of SVLaixe is to provide a scalable and extensible backend foundation for educational platforms, online exams, and assessment systems. It emphasizes:
- easy content management
- modular architecture
- clean separation of concerns
- API-driven data access
- maintainability for future feature expansion

## Prerequisites

Before running the project, make sure you have the following installed:

- .NET 8 SDK
- Visual Studio 2022 or Visual Studio Code
- Git
- A supported database system if your solution uses one
