# Menmen's Golden House v2.0 - Audit Log

**Project**: Menmen's Golden House v2.0 Upgrade  
**Start Date**: 2026-05-28  
**Maintainer**: Simonmensi

---

## Log Format

Each log entry follows this format:

```
### [YYYY-MM-DD HH:MM] Phase X.X - Task Title

**Change Type**: [Feature/Fix/Refactor/Docs/Chore]
**Branch**: feature/phase-x-xxx
**Related Files**: 
- path/to/file1.ts
- path/to/file2.cs

**Change Summary**:
- Specific change point 1
- Specific change point 2

**Related Commit**: commit-hash
**Status**: ✅ Complete / 🔄 In Progress / ⚠️ Pending Review / ❌ Issue
```

---

## Change Log (Reverse Chronological Order)

### [2026-05-28 16:45] Phase 1 Fix - Repair Frontend Git Tracking

**Change Type**: Fix  
**Branch**: `feature/phase-1-setup`  
**Related Files**:
- `nextjs-new/`
- `README.md`
- `AUDIT_LOG.md`

**Change Summary**:
- Diagnosed GitHub Actions checkout failure: `No url found for submodule path 'nextjs-new' in .gitmodules`.
- Confirmed `nextjs-new` was tracked as Git mode `160000`, meaning a submodule/gitlink, but no `.gitmodules` mapping existed.
- Removed the broken gitlink and recreated `nextjs-new` as a normal tracked Next.js source directory.
- Added a minimal Next.js 16 App Router frontend with home page, health page, API URL helper, TypeScript, Tailwind v4, ESLint config, and package lock.
- Removed generated root Markdown clutter, keeping root documentation focused on `README.md`, `PLAN.md`, and `AUDIT_LOG.md`.

**Status**: ✅ Complete

---

### [2026-05-28 14:30] Phase 1 Complete - Infrastructure Setup

**Change Type**: Feature  
**Branch**: `feature/phase-1-setup` (to be created)
**Related Files**:
- nextjs-new/ (complete)
- backend/ (complete)
- README.md (updated)
- start-dev.bat

**Change Summary**:
- ✅ **P1.1**: Next.js 16 initialized with TypeScript + Tailwind
- ✅ **P1.2**: ASP.NET Core 8 solution created (Api + Core + Data layers)
- ✅ **P1.3**: Complete database schema designed with EF Core
  - Course management entities (Course → Chapter → Document)
  - Photo gallery with timestamps
  - Portfolio projects with tags
  - CV/Resume components (Experience, Education, Skills)
- ✅ **P1.4**: Frontend-backend communication configured
  - CORS setup for localhost:3000
  - Health check endpoint implemented
  - Sample Courses API with full CRUD operations
  - Swagger documentation enabled
- ✅ **P1.5**: CI/CD foundation (partial)
  - docker-compose.yml created
  - Development startup script created
  - PostgreSQL setup instructions documented
  - Backend builds successfully

**Project Structure Created**:
```
- nextjs-new/          → Next.js 16 frontend (ready for npm install)
- backend/             → ASP.NET Core 8 API (ready to run)
- docusaurus-old/      → Original project archived
- docker-compose.yml   → PostgreSQL dev database
```

**Verification Status**:
- ✅ Backend builds without errors
- ✅ Database models designed
- ✅ CORS configured
- ✅ API structure established
- ⏳ Database connection (awaiting PostgreSQL setup)
- ⏳ Frontend-backend integration test (awaiting localhost startup)

**Next Phase**: Phase 2 - Content Migration

---

### [2026-05-28 00:00] Project Initialization

**Change Type**: Chore  
**Related Files**:
- PLAN.md
- AUDIT_LOG.md

**Change Summary**:
- ✅ Created comprehensive project planning document (PLAN.md)
- ✅ Created change tracking document (AUDIT_LOG.md)
- ✅ Confirmed tech stack: Next.js 16 + C# ASP.NET Core 8 + PostgreSQL + AWS Amplify
- ✅ Planned 11 development phases
- ✅ Reorganized project structure: docusaurus-old + nextjs-new + backend

**Decision Records**:
- **Backend Framework**: C# ASP.NET Core 8 (Reason: Existing project experience (Aori, FoodWaste), enterprise capability demonstration, easier future maintenance and upgrades)
- **Database**: PostgreSQL for both development and production (Unified choice for easier DevOps)
- **Deployment Platform**: AWS Amplify (Reason: Native Next.js support, automatic CI/CD, low cost for small traffic)
- **Storage Solution**: TBD (Candidates: S3 or local storage)

**Notes**: 
- Preserve Golden House visual style
- Support real-time content updates
- Gradual phase-by-phase iteration

---

## Key Decision Records

| Decision Item | Choice | Alternative | Rationale |
|---------------|--------|-------------|-----------|
| Backend Language | C# | Python / Node.js | Existing project experience, enterprise-grade, easier maintenance |
| Backend Framework | ASP.NET Core 8 | FastAPI / Express | Type safety, dependency injection, mature ecosystem |
| Frontend Framework | Next.js 16 | Docusaurus / Vue | Full-stack support, mature App Router |
| Database | PostgreSQL | MongoDB / MySQL | Relational model, ACID guarantees, unified dev/prod |
| Deployment | AWS Amplify | Vercel / Heroku | Native full-stack support |
| File Storage | TBD | S3 / Local | Cost vs convenience tradeoff |

---

## Milestone Tracking

- [ ] **M1**: Infrastructure Ready (Phase 1) - Target: Week 1
- [ ] **M2**: Content Imported (Phase 2) - Target: Week 2
- [ ] **M3**: Core Features MVP (Phase 3-4) - Target: Week 3-4
- [ ] **M4**: All Features Complete (Phase 5-7) - Target: Week 5
- [ ] **M5**: UI Unified (Phase 8) - Target: Week 5
- [ ] **M6**: Production Ready (Phase 10) - Target: Week 6
- [ ] **M7**: Live & Operating (Phase 11) - Target: Week 7

---

## Current Progress Overview

### Project Phase Status
- 🔄 Phase 1: Project Initialization & Infrastructure - **Frontend/backend foundation restored, verification in progress**
- ⏹️ Phase 2: Content Migration - Not Started
- ⏹️ Phase 3: Course Notes Module - Not Started
- ⏹️ Phase 4: Photo Gallery Module - Not Started
- ⏹️ Phase 5: Projects Feature - Not Started
- ⏹️ Phase 6: CV Feature - Not Started
- ⏹️ Phase 7: About Page - Not Started
- ⏹️ Phase 8: UI Integration - Not Started
- ⏹️ Phase 9: Advanced Features - Not Started
- ⏹️ Phase 10: Testing & Deployment - Not Started
- ⏹️ Phase 11: Documentation & Maintenance - Not Started

### Task Completion Summary
- Total: 11 Phases, 50+ subtasks
- Completed: Phase 1 foundation tasks
- In Progress: Phase 1 CI/frontend-backend verification
- Remaining: Phase 2+

---

## Issue Tracker

### Open Issues
1. **CI Verification** - Push `feature/phase-1-setup` and confirm GitHub Actions no longer fails during checkout.
2. **Frontend-Backend Runtime Verification** - Run both apps locally and confirm `/health` reaches `/api/health`.
3. **File Storage Solution** - Should we use S3 or local storage?
4. **User Authentication** - Do we need GitHub OAuth login?
5. **Comment System** - Should we implement article comments?

### Resolved Issues
(None yet)

---

## Team Notes

### Important Reminders
- ⚠️ Phase 1 MUST complete front-end/back-end communication verification before Phase 2
- ⚠️ Backup original Docusaurus content before migration in Phase 2
- ⚠️ Test AWS Amplify configuration early

### Resource Links
- Original Project: https://github.com/Simonmensi/menmen-golden-house-website
- Reference Project: https://github.com/Simonmensi/Simonmensi.github.io
- Reference Website: https://simonmensi.github.io/
- AWS Amplify: https://aws.amazon.com/amplify/
- Reference Projects (Aori, FoodWaste): Check GitHub repositories

---

## Quick Reference

### Checklist for Starting New Phase
- [ ] Mark Phase as in-progress in PLAN.md
- [ ] Create GitHub feature branch: `feature/phase-X-xxx`
- [ ] Add new entry to this AUDIT_LOG
- [ ] Make initial commit
- [ ] Start coding

### Checklist for Completing Phase
- [ ] All subtasks completed
- [ ] Code review passed
- [ ] Tests passing
- [ ] Documentation updated
- [ ] Mark complete in AUDIT_LOG
- [ ] Create Pull Request
- [ ] Merge to main branch

---

**Last Updated**: 2026-05-28 00:00  
**Next Step**: Start Phase 1 - Project Initialization
