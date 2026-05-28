@echo off
REM Development startup script for Menmen's Golden House v2.0

echo.
echo ===== Menmen's Golden House v2.0 - Development Environment =====
echo.

REM Check if Docker is running and start PostgreSQL
echo Checking PostgreSQL...
docker ps | findstr menmen-golden-house-db >nul
if errorlevel 1 (
    echo Starting PostgreSQL container...
    docker-compose up -d
    timeout /t 3
) else (
    echo PostgreSQL is already running
)

REM Start backend in a new window
echo Starting ASP.NET Core backend on http://localhost:5000...
start cmd /k "cd backend && dotnet run --project MenmenGoldenHouse.Api"

REM Start frontend in a new window
echo Starting Next.js frontend on http://localhost:3000...
timeout /t 2
start cmd /k "cd nextjs-new && npm run dev"

echo.
echo ===== Development Environment Started =====
echo Frontend:  http://localhost:3000
echo Backend:   http://localhost:5000
echo Swagger:   http://localhost:5000/swagger/index.html
echo PostgreSQL: localhost:5432
echo.
