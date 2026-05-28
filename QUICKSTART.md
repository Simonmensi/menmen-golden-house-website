# Quick Start Reference

## 🏃 Run Everything (3 Simple Commands)

### Terminal 1: Backend
```bash
cd D:\Ph.D\menmen_golden_room\backend
dotnet run --project MenmenGoldenHouse.Api
```
✅ Wait for: `Now listening on: http://localhost:5000`

### Terminal 2: Frontend
```bash
cd D:\Ph.D\menmen_golden_room\nextjs-new
npm run dev
```
✅ Wait for: `Ready in 1.2s`

### Terminal 3: Database (if needed)
```bash
cd D:\Ph.D\menmen_golden_room
docker-compose up -d
```
✅ PostgreSQL will be available at `localhost:5432`

---

## 🔍 Test Your Setup

1. **Health Check**: http://localhost:3000/health
   - Shows backend connection status
   - Auto-refreshes every 5 seconds

2. **Full Test Suite**: http://localhost:3000/test
   - Tests all 4 API endpoints
   - Shows response times
   - Color-coded pass/fail

3. **Swagger API Docs**: http://localhost:5000/swagger/index.html
   - Interactive API documentation
   - Try-it-out functionality

---

## 📁 Key Directories

```
D:\Ph.D\menmen_golden_room\
├── backend/                          # C# ASP.NET Core 8
│   ├── MenmenGoldenHouse.Api/        # API project
│   │   ├── Program.cs                # App configuration
│   │   ├── appsettings.json          # Settings
│   │   └── Controllers/              # API endpoints
│   ├── MenmenGoldenHouse.Core/       # Business logic
│   └── MenmenGoldenHouse.Data/       # Database layer
│
├── nextjs-new/                       # Next.js 16 frontend
│   ├── app/                          # App Router
│   │   ├── layout.tsx                # Root layout
│   │   ├── page.tsx                  # Home page
│   │   ├── health/                   # Health check page
│   │   └── test/                     # Test suite page
│   ├── components/                   # React components
│   │   └── Navigation.tsx            # Nav bar
│   ├── lib/                          # Utilities
│   │   └── api.ts                    # API client config
│   ├── package.json                  # Dependencies
│   └── .env.local                    # Environment vars
│
├── PLAN.md                           # Full roadmap (11 phases)
├── SETUP_COMPLETE.md                 # This doc + next steps
├── PORT_CONFIGURATION.md             # Port settings
└── docker-compose.yml                # PostgreSQL setup
```

---

## 🔧 Common Commands

### Backend Commands
```bash
# Run in development
dotnet run --project MenmenGoldenHouse.Api

# Build only
dotnet build

# Run tests
dotnet test

# Create database migration
dotnet ef migrations add MigrationName --project MenmenGoldenHouse.Data

# Apply migrations
dotnet ef database update --project MenmenGoldenHouse.Data
```

### Frontend Commands
```bash
# Start dev server
npm run dev

# Build for production
npm run build

# Start production server
npm start

# Lint check
npm run lint

# Run tests
npm run test
```

### Database Commands
```bash
# Start PostgreSQL in Docker
docker-compose up -d

# Stop PostgreSQL
docker-compose down

# View logs
docker-compose logs -f
```

---

## 🌐 API Endpoints

### Health & Status
- `GET /api/health` - Backend status

### Courses (CRUD)
- `GET /api/courses` - List all
- `GET /api/courses/{id}` - Get one
- `POST /api/courses` - Create
- `PUT /api/courses/{id}` - Update
- `DELETE /api/courses/{id}` - Delete

### Photos (CRUD)
- `GET /api/photos` - List all
- Similar CRUD operations...

### Projects (CRUD)
- `GET /api/projects` - List all
- Similar CRUD operations...

### CV/Resume (CRUD)
- `GET /api/cv` - List all
- Similar CRUD operations...

---

## 📊 Current Status

| Component | Port | Status |
|-----------|------|--------|
| Frontend | 3000 | ✅ Ready |
| Backend | 5000 | ✅ Ready |
| Database | 5432 | ✅ Docker-ready |
| Swagger | 5000 | ✅ Available |

---

## ⚡ Performance Tips

1. **Frontend auto-refresh**: Add to `.env.local` to disable
   ```
   NEXT_DISABLE_REFETCH_ON_REVALIDATE=1
   ```

2. **Backend performance**: Connection pooling configured in `appsettings.json`

3. **Database**: PostgreSQL with proper indexes on common queries

---

## 🆘 Need Help?

### Backend Won't Start?
- Check port 5000 isn't already in use: `netstat -ano | findstr :5000`
- Check PostgreSQL connection string in `appsettings.json`
- View error logs in terminal

### Frontend Won't Load?
- Check `npm run dev` output for errors
- Check `.env.local` has correct `NEXT_PUBLIC_API_URL`
- Clear cache: `npm cache clean --force`

### API Tests Failing?
- Verify backend is running on 5000
- Check CORS configuration in `Program.cs`
- Verify PostgreSQL is running (if database errors)

### Database Won't Connect?
- Make sure PostgreSQL is running: `docker-compose up -d`
- Check connection string: `Host=localhost;Port=5432;Database=menmen_golden_house`
- Verify credentials: `Username=menmen;Password=menmen_secure_password_123`

---

## 📞 Next Steps After Verification

1. ✅ Confirm all tests pass → Move to Phase 2
2. 📄 Create frontend pages for:
   - Courses listing & detail pages
   - Photo gallery
   - Projects showcase
   - CV/Resume
3. 🎨 Implement Golden House visual style
4. 🚀 Deploy to AWS Amplify

---

**Version**: 1.0  
**Last Updated**: 2026-05-28  
**Status**: ✅ Ready for Testing
