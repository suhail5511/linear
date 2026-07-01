# Architecture

## Project Overview
Ticketing System backend API built with .NET Core and PostgreSQL. 
This service handles all business logic, data persistence, and API 
endpoints for the ticketing system frontend.

## Tech Stack

| Layer | Technology |
|---|---|
| Runtime | .NET Core |
| Database | PostgreSQL |
| ORM | Entity Framework Core |
| API Style | RESTful API |
| Frontend | Vue.js (separate repository) |

## Project Structure
src/
├── Controllers/      → API endpoint definitions
├── Models/           → Database entity models
├── DTOs/             → Data transfer objects
├── Services/         → Business logic layer
├── Repositories/     → Database access layer
├── Migrations/       → Entity Framework migrations
├── Middleware/       → Custom middleware (auth, logging, error handling)
└── Program.cs        → Application entry point

## Architecture Pattern

This project follows a **layered architecture** pattern:

- **Controller Layer** → Receives HTTP requests and returns responses. No business logic here.
- **Service Layer** → Contains all business logic. Injected into controllers via dependency injection.
- **Repository Layer** → Handles all direct database operations using Entity Framework Core.
- **Model Layer** → Defines database entities that map directly to PostgreSQL tables.
- **DTO Layer** → Defines data shapes for API requests and responses.

## Database

| Item | Detail |
|---|---|
| Database | PostgreSQL |
| ORM | Entity Framework Core |
| Migrations | Managed via `dotnet ef migrations` |

## API Conventions

- All endpoints follow REST conventions
- Base URL: `/api/`
- Authentication: JWT Bearer token
- Response format: JSON

## Key Rules for Development

- **Controllers → Services → Repositories** — never skip layers
- Always use **DTOs** for API input and output — never expose Model classes directly
- Always add **migrations** when changing Models — never modify database directly
- Always handle errors in **Middleware** — never return raw exception messages
- Always use **dependency injection** — never instantiate services manually

## Environment Configuration

All environment-specific values must be stored in `appsettings.json` 
or environment variables.

> Never hardcode secrets in code.
