
RDBSystem/
```
│── RDBSystem.sln
│
├── RDBSystem.Core
│   ├── Entities/ (User, Product, AuditLog…)
│   ├── Interfaces/ (IUserRepository…)
│   ├── DTOs/
│   └── Exceptions/
│
├── RDBSystem.Infrastructure
│   ├── Database/OracleConnectionFactory.cs
│   ├── Repositories/UserRepository.cs
│   └── DapperConfig/
│
├── RDBSystem.Web
│   ├── Controllers/
│   ├── Models/
│   ├── Views/
│   ├── wwwroot/
│   ├── Middleware/
│   └── appsettings.json
```
Dotnet Core 9.x 
Oracle DB 11.x
Dapper + Oracle.ManagedDataAccess.Core + Microsoft.Extensions.Configuration

 Domain Driven Design  (DDD)

```
1. RDBSystem.Core (Domain Layer)
```

```
2. RDBSystem.Infrastructure (Persistence/Data Access Layer)
```

```
3. RDBSystem.Web (Presentation/Entry Point Layer
```
## How to run ?

```
1. CD to Web Project
2. dotnet watch run

```

