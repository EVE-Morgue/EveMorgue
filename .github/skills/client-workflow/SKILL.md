---
name: client-workflow
description: "Use when working on apps/client, especially for Next.js routes, components, styling, data fetching, or client-side behavior changes."
---

# Client Workflow

Use this skill for the Next.js client.

## Focus

- Respect the existing app structure under `apps/client/src/app`.
- Keep UI code practical and consistent with the current product.
- Prefer clear component boundaries and simple data flow.

## Typical Workflow

1. Check the current page, layout, and shared styling patterns before editing.
2. Keep changes aligned with the backend contract and current docs.
3. Prefer targeted component and CSS updates over broad redesigns.
4. Verify the change works on both desktop and mobile layouts.
5. Note any API dependency the client now relies on.

## Guardrails

- Do not introduce unnecessary state management.
- Do not assume undocumented backend fields exist.
- Do not change the design language without a reason tied to the task.
