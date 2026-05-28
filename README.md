# 黄金屋 v2.0 - Menmen's Golden House v2.0

A full-stack personal website upgrade project combining Next.js 16 frontend with C# ASP.NET Core 8 backend.

## 📁 Project Structure

```
menmen-golden-room/
├── nextjs-new/                 # Next.js 16 frontend application
│   ├── app/                    # App Router pages and layouts
│   ├── lib/                    # Utilities and helpers
│   ├── package.json
│   └── tsconfig.json
│
├── backend/                    # C# ASP.NET Core 8 API
│   ├── MenmenGoldenHouse.Api/  # Main Web API project
│   ├── MenmenGoldenHouse.Core/ # Business logic layer
│   ├── MenmenGoldenHouse.Data/ # Data access layer & entities
│   └── MenmenGoldenHouse.slnx  # Solution file
│
├── docusaurus-old/             # Original Docusaurus project (archived)
│   ├── docs/                   # Original documentation
│   ├── blog/                   # Original blog posts
│   └── src/                    # Original Docusaurus source
│
├── docker-compose.yml          # PostgreSQL database setup
├── PLAN.md                     # Project planning document (11 phases)
├── AUDIT_LOG.md                # Change tracking and decisions
├── .gitignore
└── README.md                   # This file
```

## 🚀 Quick Start

### Prerequisites
1. Node.js 18+ (for Next.js frontend)
2. .NET 8 SDK (for C# backend)
3. PostgreSQL 16+ or Docker

### Frontend (Next.js)
```bash
cd nextjs-new
npm install
npm run dev
# Frontend available at http://localhost:3000
```

### Backend (ASP.NET Core 8)
```bash
cd backend
dotnet restore
dotnet build
dotnet run --project MenmenGoldenHouse.Api
# API available at http://localhost:5000
# Swagger UI at http://localhost:5000/swagger/index.html
```

### Health Check
```bash
curl http://localhost:5000/api/health
# Should return: {"status":"healthy","timestamp":"..."}
```

## 📋 Project Phases

See **PLAN.md** for detailed breakdown:
- **Phase 1**: Project Initialization & Infrastructure (Current)
- **Phase 2**: Content Migration
- **Phase 3**: Course Notes Module
- **Phase 4**: Photo Gallery Module
- **Phase 5**: Projects Page
- **Phase 6**: CV Page
- **Phase 7**: About Page
- **Phase 8**: UI Integration
- **Phase 9**: Advanced Features
- **Phase 10**: Testing & Deployment
- **Phase 11**: Documentation & Maintenance

## 🛠 Tech Stack

- **Frontend**: Next.js 16 + TypeScript + Tailwind CSS + shadcn/ui
- **Backend**: C# ASP.NET Core 8 + Entity Framework Core
- **Database**: PostgreSQL
- **Deployment**: AWS Amplify + Lambda
- **CI/CD**: GitHub Actions

## 📝 Documentation

- **PLAN.md** - Complete project roadmap with all phases and tasks
- **AUDIT_LOG.md** - Change history and decision records

## 🔗 References

- Original Project: https://github.com/Simonmensi/menmen-golden-house-website
- Profile Project: https://github.com/Simonmensi/Simonmensi.github.io
- Profile Website: https://simonmensi.github.io/

## 👤 Maintainer

Simonmensi
