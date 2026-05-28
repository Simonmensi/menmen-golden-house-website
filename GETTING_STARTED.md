# Getting Started - Menmen's Golden House v2.0

Welcome! This guide will get you running the development environment locally.

---

## 📋 Prerequisites

Before starting, ensure you have:

1. **Node.js 18+** - Download from https://nodejs.org/
   ```bash
   node --version  # Should be v18 or higher
   npm --version   # Should be 8+
   ```

2. **.NET 8 SDK** - Download from https://dotnet.microsoft.com/download/dotnet/8.0
   ```bash
   dotnet --version  # Should show 8.x.x
   ```

3. **PostgreSQL 16+** - See [Database Setup](#database-setup) below

---

## 🗄️ Database Setup

### Option 1: PostgreSQL Local Installation (Windows)

1. Download PostgreSQL installer from https://www.postgresql.org/download/windows/
2. Run installer and remember the password you set for `postgres` user
3. Open pgAdmin (included with PostgreSQL) or connect via command line:
   ```bash
   psql -U postgres
   ```

4. Create database and user:
   ```sql
   CREATE USER menmen WITH PASSWORD 'menmen_secure_password_123';
   CREATE DATABASE menmen_golden_house OWNER menmen;
   GRANT ALL PRIVILEGES ON DATABASE menmen_golden_house TO menmen;
   \q  -- Exit psql
   ```

5. Test connection:
   ```bash
   psql -U menmen -h localhost -d menmen_golden_house
   \q  -- Exit psql
   ```

### Option 2: Docker (if available)

```bash
docker-compose up -d
```

This starts PostgreSQL on `localhost:5432` with the database ready to use.

---

## 🚀 Running the Development Environment

### Method 1: Two Terminal Windows

**Terminal 1 - Backend (ASP.NET Core API)**
```bash
cd backend
dotnet restore  # First time only
dotnet run --project MenmenGoldenHouse.Api
```

You should see:
```
Now listening on: http://localhost:5000
Now listening on: https://localhost:5001
Application started. Press Ctrl+C to stop...
```

**Terminal 2 - Frontend (Next.js)**
```bash
cd nextjs-new
npm install  # First time only
npm run dev
```

You should see:
```
  ▲ Next.js 16.x.x
  - ready started server on 0.0.0.0:3000, url: http://localhost:3000
```

### Method 2: Automatic Startup (Windows Batch)

On Windows, you can run:
```bash
start-dev.bat
```

This will open both frontend and backend in separate windows.

---

## ✅ Verify Everything Works

### 1. Check Backend Health

Open browser and go to: http://localhost:5000/api/health

You should see:
```json
{"status":"healthy","timestamp":"2026-05-28T..."}
```

### 2. Check Backend Documentation

Go to Swagger UI: http://localhost:5000/swagger/index.html

You'll see all available API endpoints with test capabilities.

### 3. Check Frontend

Go to: http://localhost:3000

You should see the Next.js welcome page.

### 4. Test API Connection

In browser, try this URL: http://localhost:5000/swagger/index.html

1. Click on "Courses" section
2. Click on "Try it out" for GET /api/courses
3. Click "Execute"

If the database is connected, you should get a 200 response (empty list is expected since no courses exist yet).

---

## 📚 Project Structure Overview

```
menmen-golden-room/
├── nextjs-new/              # Frontend (React + Next.js)
│   ├── app/                 # Pages and layouts
│   ├── components/          # React components
│   ├── lib/                 # Utilities
│   └── package.json
│
├── backend/                 # Backend (C# + ASP.NET Core)
│   ├── MenmenGoldenHouse.Api/      # Web API
│   ├── MenmenGoldenHouse.Core/     # Business logic
│   ├── MenmenGoldenHouse.Data/     # Database
│   └── MenmenGoldenHouse.slnx
│
├── PLAN.md                  # 11-phase project roadmap
├── AUDIT_LOG.md             # Change tracking
├── PHASE_1_SUMMARY.md       # Phase 1 details
└── POSTGRES_SETUP.md        # Database setup guide
```

---

## 🔗 Useful URLs During Development

| Component | URL | Purpose |
|-----------|-----|---------|
| Frontend | http://localhost:3000 | React/Next.js app |
| Backend Health | http://localhost:5000/api/health | API status check |
| Swagger UI | http://localhost:5000/swagger/index.html | API documentation |
| API Courses | http://localhost:5000/api/courses | Course list endpoint |

---

## 🛠️ Common Development Tasks

### Adding a New API Endpoint

1. Create controller in `/backend/MenmenGoldenHouse.Api/Controllers/`
2. Implement methods
3. Restart backend (backend auto-reloads in development)
4. Test in Swagger UI

### Adding a New Frontend Page

1. Create file in `/nextjs-new/app/`
2. Next.js file-based routing takes care of the rest
3. Frontend auto-reloads

### Working with Database

Database will auto-migrate when you first run the API. To manually:

```bash
cd backend
dotnet ef database update --project MenmenGoldenHouse.Data --startup-project MenmenGoldenHouse.Api
```

---

## 🐛 Troubleshooting

### Error: "Connection refused" on port 5000

**Solution**: Backend isn't running. Make sure to start it:
```bash
cd backend
dotnet run --project MenmenGoldenHouse.Api
```

### Error: "Connection refused" for PostgreSQL

**Solution**: Database isn't running. Either:
- Start PostgreSQL service (Windows: Services.msc)
- Or run: `docker-compose up -d`

### Error: "npm ERR!" in frontend

**Solution**: Clean cache and reinstall:
```bash
cd nextjs-new
rm -r node_modules package-lock.json
npm install
```

### HTTPS Certificate Warning

**Solution**: This is normal in development. You can:
- Accept the warning in browser
- Or run: `dotnet dev-certs https --trust`

---

## 📝 Project Phases

This is **Phase 1** of an 11-phase project. See `PLAN.md` for details:

- **Phase 1**: ✅ Infrastructure (Current)
- **Phase 2**: Content migration from old site
- **Phase 3**: Course notes module
- **Phase 4**: Photo gallery
- **Phase 5**: Projects portfolio
- ... and 6 more phases

---

## 📚 Documentation

- **PLAN.md** - Complete project roadmap
- **AUDIT_LOG.md** - Change history
- **PHASE_1_SUMMARY.md** - Phase 1 details
- **POSTGRES_SETUP.md** - Database setup
- **README.md** - Project overview

---

## 🤝 Git Workflow

```bash
# Create feature branch
git checkout -b feature/your-feature-name

# Make changes and commit
git add .
git commit -m "feat: add new feature"

# Push to remote
git push origin feature/your-feature-name

# Create Pull Request on GitHub
```

---

## ✨ Next Steps

After verifying everything works:

1. Review the project structure
2. Read `PLAN.md` for the full roadmap
3. Start working on Phase 2 (content migration)

---

**Happy coding! 🚀**

For questions, check the documentation files or review the existing code structure.
