# Copilot Instructions

## Project Guidelines

- Keep the repository aligned to the current layout and naming:
  - `apps/server/EVEMorgue.API` for HTTP/API concerns.
  - `apps/server/EVEMorgue.Core` for domain and application logic.
  - `apps/client` for the Next.js client.
- Preserve Clean Architecture boundaries.
  - Keep controllers thin.
  - Keep business logic in `.Core`.
  - Keep the client focused on presentation and API consumption.
- Treat documentation as first-class.
  - Documentation is the primary source of truth for project intent and should be updated alongside behavior changes.
  - Prefer concise, professional prose.
  - Keep root-level guidance short and move detail into `docs/`.
  - Ask clarifying questions before finalizing documentation changes when requirements are ambiguous.
- When making code changes, verify the affected layer(s) still match the architecture in `docs/architecture.md` and the product intent in `README.md`.
- Prefer minimal, targeted edits over broad refactors unless the task explicitly calls for it.
- If a change affects API contracts, client behavior, or docs, call out the impact clearly in the response.
