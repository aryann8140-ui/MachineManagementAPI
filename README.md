# MachineManagementAPI

A ASP.NET Core Web API for managing industrial machines, their maintenance logs, and assigned operators. Built with .NET 8, Entity Framework Core, and SQL Server.

## Features

- **Machine Management**: CRUD operations for machines with status tracking
- **Maintenance Logging**: Track maintenance history, costs, and details for each machine
- **Operator Management**: Assign operators to specific machines
- **RESTful API**: Clean, documented endpoints with Swagger UI support
- **Repository Pattern**: Clean separation of concerns with service and repository layers
- **DTOs**: Proper data transfer objects for API communication
- **Entity Framework Core**: ORM with SQL Server support and migrations

## Tech Stack

- **Framework**: .NET 8.0 (ASP.NET Core Web API)
- **Database**: SQL Server with Entity Framework Core
- **Architecture**: Clean Architecture (Controllers → Services → Repository → Data)
- **Documentation**: Swagger/OpenAPI
- **Other**: AutoMapper not used (manual mapping in services), Repository Pattern

## Project Structure
MachineManagementAPI/
├── Controllers/          # API Controllers
├── Data/                 # DbContext and configurations
├── Dtos/                 # Data Transfer Objects
├── Migrations/           # EF Core Migrations
├── Models/               # Domain entities
├── Repository/           # Data access layer
├── Services/             # Business logic layer
├── Properties/
├── appsettings.json
├── Program.cs
└── MachineManagementAPI.csproj


## Models

### Machine
- Id, Name, SerialNumber, Location, Status, PurchaseDate
- Relationships: One-to-Many with MaintenanceLogs and Operators

### MaintenanceLog
- Id, MachineId, Description, PerformedBy, MaintenanceDate, Cost

### Operator
- Id, Name, Email, AssignedMachineId

### Enum: MachineStatus
(Active, Inactive, UnderMaintenance, etc.)

## Getting Started

### Prerequisites
- .NET 8 SDK
- SQL Server (Local or remote)
- Visual Studio 2022 or VS Code

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/aryann8140-ui/MachineManagementAPI.git
   cd MachineManagementAPI
   Update Database Connection
2. **Update Database Connection**
3. **Apply Migrations**  : dotnet ef database update
4. **Run the Application** : dotnet run
5. **Access Swagger UI** : Navigate to https://localhost:xxxx/swagger (check console for port)

API Endpoints
Machines

GET /api/Machine - Get all machines
GET /api/Machine/{id} - Get machine by ID
POST /api/Machine - Create new machine
PUT /api/Machine?id={id} - Update machine
DELETE /api/Machine/{id} - Delete machine
GET /api/Machine/MachineStatus/{status} - Filter by status

Maintenance & Operators
(Similar CRUD endpoints available through their respective controllers)
HTTP Client Example
The project includes MachineManagementAPI.http for testing endpoints in VS Code or similar tools.
Development
Adding New Features

Create/Update Model in /Models
Add corresponding DTOs in /Dtos
Implement Repository in /Repository
Add Service in /Services
Create Controller endpoints

Database Migrations
dotnet ef migrations add MigrationName
dotnet ef database update
Technologies Used

Microsoft.EntityFrameworkCore.SqlServer
Swashbuckle.AspNetCore (Swagger)
ASP.NET Core Minimal API features where applicable

Author - Aryan  https://github.com/aryann8140-ui
