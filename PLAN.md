# Menmen's Golden House v2.0 - Project Plan

**Project Goal**: Upgrade Docusaurus personal website to a full-stack Next.js application with mature features and dynamic content management

**Tech Stack**: Next.js 16 + C# ASP.NET Core 8 + PostgreSQL + AWS Amplify  
**Duration**: Multi-phase iteration  
**Maintainer**: Simonmensi

---

## Project Phase Planning

### Phase 1: Project Initialization & Infrastructure Setup [Bootstrap Phase] ✅ 95% COMPLETE
**Branch**: `feature/phase-1-setup`  
**Goal**: Establish Next.js + ASP.NET Core 8 + Database foundation

- [x] **P1.1** - Initialize Next.js 16 Project
  - Use standard Next.js template (App Router)
  - Configure Tailwind CSS + shadcn component library
  - Setup TypeScript support
  - File structure: src/app, src/components, src/lib
  - **Status**: ✅ Complete (2026-05-28)

- [x] **P1.2** - Configure C# ASP.NET Core 8 Backend
  - Create ASP.NET Core 8 Web API project (/backend)
  - Setup dependency injection container (DI)
  - Configure database connection (Entity Framework Core)
  - Establish base API controller structure
  - **Status**: ✅ Complete - Fixed port to 5000 (2026-05-28)

- [x] **P1.3** - Database Design & Initialization
  - Design data models (Courses, Photos, Projects, CV, etc.)
  - Create Entity Framework Core DbContext
  - Setup EF Core Migrations tool
  - Configure PostgreSQL locally
  - Create database initialization scripts
  - **Status**: ✅ Complete - Schema designed, docker-compose ready (2026-05-28)

- [x] **P1.4** - Front-end Backend Communication
  - Configure CORS support ✅
  - Setup API client utilities (fetch/axios) ✅
  - Environment variable management (dev/prod) ✅
  - Error handling and logging framework ✅
  - **Status**: ✅ Complete - Health check and test pages created (2026-05-28)
  - **New**: Added `/health` page for quick verification
  - **New**: Added `/test` page for full API test suite

- [ ] **P1.5** - CI/CD Initialization
  - GitHub Actions workflow foundation
  - AWS Amplify configuration (amplify.yml)
  - Automated deployment scripts
  - Local development startup scripts (docker-compose ready)
  - **Status**: ⏳ Pending - Will complete after backend verification

**Completion Criteria**: 
- ✅ Both frontend and backend can run independently
- ✅ Health check endpoint working
- ⏳ Verify connection via API test page (PENDING - awaiting backend restart with correct port)
- ✅ Documentation created: SETUP_COMPLETE.md, QUICKSTART.md, PORT_CONFIGURATION.md

**Documentation**:
- `/SETUP_COMPLETE.md` - Setup verification guide
- `/QUICKSTART.md` - Quick reference for running everything
- `/PORT_CONFIGURATION.md` - Port configuration details
- `/PHASE_1_SUMMARY.md` - Detailed phase status

---

### Phase 2: Import Existing Content [Data Migration]
**Branch**: `feature/phase-2-content-migration`  
**Goal**: Migrate content from original Docusaurus to new system

- [ ] **P2.1** - Analyze & Convert Class Notes Content
  - Scan original docs/class-notes content
  - Design content categorization structure (JSON format)
  - Create migration scripts

- [ ] **P2.2** - Migrate Blog Posts
  - Extract all articles from blog/ folder
  - Convert metadata format (YAML → JSON)
  - Import to new database

- [ ] **P2.3** - Organize Photo Resources
  - Organize all digital images
  - Create photo metadata (date, description, etc.)
  - Upload to storage system (TBD: S3 or local)

- [ ] **P2.4** - Migrate Other Resources
  - Migrate About Me information
  - Preserve logo and static assets
  - Adapt custom CSS styles

**Completion Criteria**: All original content successfully imported to new database, zero data loss

---

### Phase 3: Core Features Development - Class Notes Module [Feature 1]
**Branch**: `feature/phase-3-course-notes`  
**Goal**: Implement dynamic course notes management system (Google Drive-like)

#### Backend Requirements:
- [ ] **P3.1** - Course Data Models & APIs
  - Database models: Course, Chapter, Document
  - API endpoints: CRUD courses/chapters/documents
  - Access control (only owner can edit)
  - File upload handling (PDF, Word, Images, etc.)

- [ ] **P3.2** - File Storage & Version Management
  - Configure S3 or local storage
  - Store file metadata
  - Simple version history (optional)

#### Frontend Requirements:
- [ ] **P3.3** - Course List Page
  - Display all course cards
  - Search and filter functionality
  - "Add Course" button (with plus icon)

- [ ] **P3.4** - Course Detail Page
  - Show course information and document list
  - Support CRUD operations
  - File upload interface

- [ ] **P3.5** - File Management Interface
  - Drag-and-drop upload
  - File preview (PDF, images)
  - Delete functionality

**Completion Criteria**: Complete course management system functional on web, supports file upload and organization

---

### Phase 4: Core Features Development - Photo Gallery Module [Feature 2]
**Branch**: `feature/phase-4-photo-gallery`  
**Goal**: Implement timestamp-based photo diary system

#### Backend Requirements:
- [ ] **P4.1** - Photo Data Models & APIs
  - Database models: Photo, PhotoDate
  - API endpoints: upload, query, delete photos
  - Query photos by date stamp
  - Store metadata (upload time, description, etc.)

#### Frontend Requirements:
- [ ] **P4.2** - Photo Gallery Main Page
  - Date picker (display current date, support date change)
  - Grid display of photos for that date
  - Real-time date sync

- [ ] **P4.3** - Photo Upload Functionality
  - Drag-and-drop or file selector upload
  - Image preview and editing (crop, add description)
  - Upload progress bar

- [ ] **P4.4** - Photo Viewing & Management
  - Lightbox viewing mode
  - Photo delete and edit
  - Timeline display of photos

**Completion Criteria**: Can upload, view, delete photos for different dates, forming a photo diary

---

### Phase 5: Integrated Features Development - Projects Page [Feature 3]
**Branch**: `feature/phase-5-projects`  
**Goal**: Display personal project portfolio (migrate from github.io)

#### Backend Requirements:
- [ ] **P5.1** - Project Data Models & APIs
  - Database models: Project, ProjectTag
  - API endpoints: get project list, details
  - Support tags and categories

#### Frontend Requirements:
- [ ] **P5.2** - Projects List Page
  - Project card grid layout
  - Tag filtering functionality
  - Search capability

- [ ] **P5.3** - Project Detail Page
  - Project description, tech stack, links
  - Project screenshots/demo
  - GitHub links

**Completion Criteria**: Projects page fully functional, displays all major projects

---

### Phase 6: Integrated Features Development - CV Page [Feature 4]
**Branch**: `feature/phase-6-cv`  
**Goal**: Create exportable CV/Resume page

#### Backend Requirements:
- [ ] **P6.1** - CV Data Models & APIs
  - Database models: Experience, Education, Skill
  - API endpoints: get CV content
  - Support multi-format export (JSON, PDF)

#### Frontend Requirements:
- [ ] **P6.2** - CV Display Page
  - Professional resume layout
  - Edit mode (personal use)
  - Print-friendly styling

- [ ] **P6.3** - Export Functionality
  - Export to PDF
  - Generate shareable link

**Completion Criteria**: CV page polished and functional, supports PDF export

---

### Phase 7: Update About Page [Feature 5]
**Branch**: `feature/phase-7-about`  
**Goal**: Enhance About Me page functionality

- [ ] **P7.1** - About Page Design & Implementation
  - Personal information display
  - Social media links
  - Personal statement/introduction
  - Contact information

**Completion Criteria**: About page aligns with new design, information complete

---

### Phase 8: Navigation & Overall UI [Integration Phase]
**Branch**: `feature/phase-8-ui-integration`  
**Goal**: Unify frontend design, preserve Golden House style

- [ ] **P8.1** - Redesign Navigation Bar
  - Preserve Golden House visual style
  - Add new feature menu items
  - Responsive mobile menu

- [ ] **P8.2** - Footer and Layout
  - Unified footer design
  - Global styling and theme
  - Dark/light mode toggle (optional)

- [ ] **P8.3** - Responsive Design
  - Mobile optimization
  - Tablet adaptation
  - Cross-browser testing

**Completion Criteria**: Entire website visually unified and beautiful, functional on all devices

---

### Phase 9: Advanced Features [Enhancement Phase]
**Branch**: `feature/phase-9-advanced`  
**Goal**: Optional enhancement features

- [ ] **P9.1** - Search Functionality
  - Full-site search (courses, articles, projects, etc.)
  - Search index optimization

- [ ] **P9.2** - User Authentication (if needed)
  - GitHub OAuth login (optional)
  - Content permission management

- [ ] **P9.3** - Comment/Interaction Features (optional)
  - Article comment system
  - Feedback form

- [ ] **P9.4** - Performance Optimization
  - Image optimization and CDN
  - Code splitting and preloading
  - Caching strategy

**Completion Criteria**: Website performs excellently with fast load times

---

### Phase 10: Testing & Deployment [Release Phase]
**Branch**: `feature/phase-10-deployment`  
**Goal**: Comprehensive testing coverage and production deployment

- [ ] **P10.1** - Unit Testing
  - Backend API testing (xUnit/NUnit)
  - Frontend component testing (Jest/Vitest)

- [ ] **P10.2** - Integration Testing
  - E2E testing (Cypress/Playwright)
  - Frontend-backend integration testing

- [ ] **P10.3** - AWS Deployment Preparation
  - Migrate database to AWS RDS
  - Configure AWS Lambda/Amplify
  - Environment variables and secrets management

- [ ] **P10.4** - Deploy & Monitor
  - Initial deployment to Amplify
  - Setup automatic CI/CD
  - Error logging and monitoring

- [ ] **P10.5** - Domain & SSL
  - Configure custom domain
  - SSL certificate setup
  - DNS configuration

**Completion Criteria**: Website successfully deployed to AWS Amplify, accessible on public internet

---

### Phase 11: Documentation & Maintenance [Final Phase]
**Branch**: `feature/phase-11-docs`  
**Goal**: Complete documentation and maintenance guide

- [ ] **P11.1** - Technical Documentation
  - API documentation (Swagger)
  - Deployment instructions
  - Environment configuration guide

- [ ] **P11.2** - User Guide
  - How to add courses
  - How to upload photos
  - How to update projects

- [ ] **P11.3** - Code Cleanup
  - Remove deprecated code
  - Code refactoring
  - Dependency updates

**Completion Criteria**: Project fully documented, easy to maintain

---

## Milestone Checkpoints

| Milestone | Completion Criteria | Target |
|-----------|-------------------|--------|
| **M1: Infrastructure Ready** | Phase 1 complete, frontend-backend communication verified | Week 1 |
| **M2: Content Imported** | Phase 2 complete, zero data loss | Week 2 |
| **M3: Core Features MVP** | Phase 3-4 complete, both major features functional | Week 3-4 |
| **M4: All Features Complete** | Phase 5-7 complete, all features ready | Week 5 |
| **M5: UI Unified** | Phase 8 complete, visual style consistent | Week 5 |
| **M6: Production Ready** | Phase 10 complete, testing passed | Week 6 |
| **M7: Live & Operating** | Phase 11 complete, documentation complete | Week 7 |

---

## Technical Details Reference

### Frontend
- **Framework**: Next.js 16 (App Router)
- **Styling**: Tailwind CSS + shadcn/ui
- **State Management**: TanStack Query / Zustand
- **Forms**: React Hook Form
- **Testing**: Vitest + @testing-library
- **Deployment**: AWS Amplify

### Backend
- **Framework**: C# ASP.NET Core 8 Web API
- **ORM**: Entity Framework Core 8
- **Database**: PostgreSQL (dev + prod)
- **Migrations**: EF Core Migrations
- **Validation**: FluentValidation
- **Logging**: Serilog
- **Testing**: xUnit / NUnit
- **Deployment**: AWS Lambda / EC2 / Container

### Database
- **Development Environment**: PostgreSQL (local or Docker)
- **Production Environment**: AWS RDS PostgreSQL

### Storage
- **File Storage**: S3 or local storage (TBD)
- **CDN**: CloudFront (optional)

---

## Important Notes

1. **Preserve Golden House Style** - Maintain original visual characteristics in design
2. **Real-time Updates** - Amplify natively supports real-time updates
3. **Optimize for Small Traffic** - Cost-first, no over-engineering needed
4. **Iterative Progress** - Test and review after each Phase completion
5. **Data Backup** - Regular PostgreSQL database backups

---

## Git Workflow Rules

1. **One Feature Branch Per Phase/Feature** - Each phase or standalone feature must be developed on its own branch, for example `feature/phase-1-setup`.
2. **Complete Before Merge** - Finish implementation, verification, and documentation updates on the feature branch before merging.
3. **Merge Back To Main** - After the feature branch is complete and reviewed, merge it back into `main`.
4. **Branch From Updated Main** - Start the next phase/feature only after switching back to the updated `main` branch and creating the next feature branch from there.
5. **Do Not Stack Feature Branches** - Avoid creating the next feature branch from an unfinished feature branch unless explicitly discussed and approved.

---

**Last Updated**: 2026-05-28  
**Status**: Planning → Ready to start Phase 1
