---
name: docs-workflow
description: "Use when updating README, docs/, architecture notes, API references, or any project guidance that explains how the system works."
---

# Docs Workflow

Use this skill for documentation work across the repository.

## Focus

- Keep docs aligned with the current codebase and repo layout.
- Preserve the docs-first structure already used in this project.
- Prefer concise, accurate, and maintainable prose.

## Typical Workflow

1. Check the related code or configuration before editing docs.
2. Match terminology to the existing architecture and product language.
3. Update the smallest relevant doc set instead of duplicating content.
4. Keep top-level docs short and move deeper material into `docs/`.
5. Call out any behavior or contract changes that documentation now depends on.

## Guardrails

- Do not invent behavior that is not present in the codebase.
- Do not widen scope beyond the user-facing change being documented.
- Do not create duplicate guidance in multiple places unless the audience differs.
