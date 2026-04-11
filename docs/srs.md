# Software Requirements Specification (SRS)

## 1. Introduction

### 1.1 Purpose
This document defines the product and technical requirements for `EveMorgue`. It serves as the shared reference for planning, implementation, and review across the team.

### 1.2 Product Positioning
`EveMorgue` is a website for EVE Online ship-loss intelligence, focused on fast fitting analysis and clear loss insights.

### 1.3 Target Audience
- EVE Online players
- Developers and contributors

### 1.4 Document Status
- Version: `v0.1`
- Owner: `EveMorgue Team`
- Last updated: `2026-04-11`

---

## 2. Scope

### 2.1 In Scope
- Ship loss search by `shipId`
- Optional item fit filtering by `itemId`
- Ship keyword search
- Ship details lookup
- Website experience through `.Client`
- Backend API through `.API` and business logic in `.Core`

### 2.2 Out of Scope (Current)
- Public API SLA/guarantees
- Authentication and user accounts
- Persistent analytics warehouse
- Monetization and billing features

---

## 3. Stakeholders

- Product: Define priorities and roadmap
- Backend: `.API` and `.Core` implementation
- Frontend: `.Client` UX and flows
- Contributors: Documentation, testing, improvements

---

## 4. Functional Requirements

- `FR-001` The system shall return ship losses for a valid `shipId`.
- `FR-002` The system shall filter losses by `itemId` when provided.
- `FR-003` The system shall support ship search by keyword.
- `FR-004` The system shall return ship details by `shipId`.
- `FR-005` The website shall display loss search results and ship details clearly.
- `FR-006` The backend shall integrate zKillboard and ESI data sources.

---

## 5. Non-Functional Requirements

- `NFR-001` Performance: Use parallel external calls where safe.
- `NFR-002` Reliability: Handle upstream API failures gracefully.
- `NFR-003` Maintainability: Enforce Clean Architecture boundaries (`.API`, `.Core`, `.Client`).
- `NFR-004` Scalability: Support future public API evolution.
- `NFR-005` Observability: Log key request and integration events.

---

## 6. Architecture Constraints

- `.API` handles HTTP and orchestration only.
- `.Core` contains business rules and abstractions.
- `.Client` contains UI and client-side experience.
- Infrastructure concerns must not leak into domain rules.

---

## 7. API Requirements (Current Internal Use)

- `GET /api/search?shipId={shipId}&itemId={itemId}`
- `GET /api/ships/search?keyword={keyword}`
- `GET /api/ships/{shipId}`

Detailed request/response examples are maintained in `docs/api.md`.

---

## 8. Acceptance Criteria (MVP)

- Search flow returns relevant losses for valid `shipId`.
- Item filtering correctly narrows result set.
- Ship keyword search returns expected candidates.
- Ship details endpoint returns consistent core fields.
- Documentation remains synchronized with behavior changes.

---

## 9. Risks and Assumptions

### 9.1 Assumptions
- External providers (zKillboard/ESI) remain reachable.
- Source APIs maintain compatible data formats.

### 9.2 Risks
- Third-party rate limits may affect latency.
- External schema changes may break parsing.
- Data quality variance across upstream sources.

---

## 10. Milestones

### Now
- Stabilize core search and detail workflows
- Improve docs completeness and consistency

### Next
- Add Redis caching option
- Add advanced filtering and analytics storage

### Later
- Public API release with versioning strategy
- Authentication and controlled access

---

## 11. Definition of Done (Team)

A task is complete when:
- Code is merged through PR with required approvals
- Build/tests pass
- Relevant docs in `docs/` are updated
- No architecture boundary violations are introduced
