# PostgreSQL Setup Instructions

Since Docker is not available in the current environment, here are the manual setup instructions:

## Option 1: Use PostgreSQL Locally (Recommended)

1. Download and install PostgreSQL 16+ from https://www.postgresql.org/download/
2. Create a new database and user:
   ```sql
   CREATE USER menmen WITH PASSWORD 'menmen_secure_password_123';
   CREATE DATABASE menmen_golden_house OWNER menmen;
   GRANT ALL PRIVILEGES ON DATABASE menmen_golden_house TO menmen;
   ```

3. The connection string is configured in `backend/MenmenGoldenHouse.Api/appsettings.json`

## Option 2: Use Docker (if available)

```bash
docker-compose up -d
```

This will start PostgreSQL on localhost:5432 with credentials:
- Username: menmen
- Password: menmen_secure_password_123
- Database: menmen_golden_house

## Running the Backend

Once PostgreSQL is running:

```bash
cd backend
dotnet restore
dotnet build
dotnet run --project MenmenGoldenHouse.Api
```

The API will be available at:
- HTTP: http://localhost:5000
- HTTPS: https://localhost:5001
- Swagger UI: http://localhost:5000/swagger/index.html

## Health Check

Test the API connection:
```bash
curl http://localhost:5000/api/health
```

Should return:
```json
{"status":"healthy","timestamp":"2026-05-28T..."}
```
