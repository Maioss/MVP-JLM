# Barbería JLM

Aplicación full-stack para gestión de barberías.

## Stack

- **Backend:** .NET 8, EF Core 8, PostgreSQL 16, JWT, Arquitectura Hexagonal
- **Frontend:** React 18, TypeScript, Vite (próximamente)

## Requisitos

- .NET 8 SDK
- Docker Desktop
- Node.js 20+ (para frontend)

## Cómo levantar el backend

1. `docker compose up -d` (levanta PostgreSQL)
2. `cd src/BarberiaJLM.Api`
3. `dotnet run`
4. Abrir Swagger en `http://localhost:5xxx/swagger`

## Credenciales iniciales (seed)

- **SuperAdmin:** `superadmin@barberiajlm.com` / `Admin123!`

## Comandos útiles EF Core

```bash
# Crear migración
dotnet ef migrations add <Name> -p src/BarberiaJLM.Infrastructure -s src/BarberiaJLM.Api

# Aplicar migraciones
dotnet ef database update -p src/BarberiaJLM.Infrastructure -s src/BarberiaJLM.Api
```
