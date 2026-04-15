---
name: server-workflow
description: "Use when working on apps/server/EVEMorgue.API or apps/server/EVEMorgue.Core, especially for controllers, DTOs, services, contracts, or API behavior changes."
---

# Server Workflow

Use this skill for backend work in the ASP.NET Core solution.

## Focus

- Preserve Clean Architecture boundaries.
- Keep HTTP concerns in `.API`.
- Keep domain and use-case logic in `.Core`.
- Prefer small, reviewable changes.

## Typical Workflow

1. Inspect the existing API surface and Core abstractions before editing.
2. Match existing naming, DTO shape, and dependency direction.
3. Keep controllers thin and delegate behavior into Core services or contracts.
4. Update tests or validation steps when the behavior changes.
5. Confirm any client-facing contract change is intentional.

## Guardrails

- Do not move business logic into controllers.
- Do not add unnecessary layers or abstractions.
- Do not change public API behavior without noting the downstream effect.
