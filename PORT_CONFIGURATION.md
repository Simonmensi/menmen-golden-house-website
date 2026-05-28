# Phase 1 - Port Configuration & Health Check Setup

**Date**: 2026-05-28  
**Issue**: Backend was running on port 5064 instead of 5000

---

## ✅ Fixed

### 1. Backend Port Configuration
- Updated `launchSettings.json` to use port **5000** instead of 5064
- Updated HTTPS port to **7001** (was 7263)
- **File**: `/backend/MenmenGoldenHouse.Api/Properties/launchSettings.json`

### 2. Frontend API Configuration
- Created `/nextjs-new/lib/api.ts` with:
  - `API_BASE_URL` configuration
  - `API_ENDPOINTS` object with all endpoints
  - `apiFetch` helper function with default headers
- Created `/nextjs-new/.env.local` for environment variables
- **Files**:
  - `/nextjs-new/lib/api.ts`
  - `/nextjs-new/.env.local`

### 3. Health Check Page
- Created `/nextjs-new/app/health/page.tsx`
- Auto-refreshing health check UI
- Shows backend connection status
- Lists all available API endpoints
- Displays configuration and troubleshooting tips
- **Access**: http://localhost:3000/health

---

## 🚀 What to Do Now

### Step 1: Restart Backend

In your backend terminal (currently running):
1. Press `Ctrl+C` to stop
2. Run again:
   ```bash
   cd backend
   dotnet run --project MenmenGoldenHouse.Api
   ```

You should now see:
```
Now listening on: http://localhost:5000
Now listening on: https://localhost:7001
```

### Step 2: Test Health Check

Visit: **http://localhost:3000/health**

You should see:
- ✅ "Backend is healthy" 
- Status and timestamp from the API
- List of all configured endpoints

---

## 🔗 Working Endpoints

Once backend is running on correct port:

| Endpoint | URL | Purpose |
|----------|-----|---------|
| Health | http://localhost:5000/api/health | Quick connection check |
| Swagger UI | http://localhost:5000/swagger/index.html | API documentation |
| Courses | http://localhost:5000/api/courses | Course management |

---

## 📝 Frontend Configuration

The frontend now uses environment variables for the API URL:

**File**: `/nextjs-new/.env.local`
```
NEXT_PUBLIC_API_URL=http://localhost:5000
```

To change API URL:
1. Edit `.env.local`
2. Restart Next.js dev server

---

## 💾 Files Modified

1. `/backend/MenmenGoldenHouse.Api/Properties/launchSettings.json`
   - Changed port from 5064 → 5000
   - Changed HTTPS port from 7263 → 7001

2. `/nextjs-new/lib/api.ts` (NEW)
   - Centralized API configuration
   - API endpoint constants
   - Fetch helper

3. `/nextjs-new/.env.local` (NEW)
   - Environment variables for frontend

4. `/nextjs-new/app/health/page.tsx` (NEW)
   - Health check page at /health route
   - Real-time status monitoring

---

## ✨ Next Features Ready

- Health check page auto-refreshes every 5 seconds
- API configuration centralized in one file
- Easy to switch between dev/prod environments
- Error handling with clear messages

---

## 🔍 If Still Not Working

1. **Check backend is actually running**:
   ```bash
   netstat -ano | findstr :5000
   ```

2. **Check if PostgreSQL needed**:
   - For now, the API should run even without database
   - Health check doesn't require database

3. **Clear npm cache** (frontend):
   ```bash
   cd nextjs-new
   npm cache clean --force
   npm install
   npm run dev
   ```

---

**Status**: ✅ Ready to verify connection!
