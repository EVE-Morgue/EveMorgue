# EveMorgue

EveMorgue is a ship-loss intelligence website for EVE Online, built to help players quickly inspect fittings, identify item usage, and understand loss patterns.

It currently operates as a web product and is designed to support a public API in future releases.

## Why EveMorgue

- Fast ship-loss analysis powered by zKillboard and ESI data
- Focused workflow for both EVE players and developers
- Clean Architecture foundation for long-term maintainability
- Ready for extension into public API scenarios

## Project Showcase

### Core Capabilities

- Loss analysis by `shipId` with optional `itemId` fit filtering
- Ship search by keyword using cached ship metadata
- Ship detail lookup with ESI-backed data

### Architecture Direction

The solution follows Clean Architecture naming and boundaries, mapped to the current repo layout:

```plaintext
apps/server/EVEMorgue.API   ASP.NET Core Web API entry point
apps/server/EVEMorgue.Core  Domain and application logic
apps/client                 Next.js website
```

## Documentation

This repository uses a docs-first approach. Full technical details are maintained under `docs/`.

- [Documentation Index](docs/README.md)
- [Architecture](docs/architecture.md)
- [API Reference](docs/api.md)
- [Software Requirements Specification (SRS)](docs/srs.md)
- [Contributing](docs/contributing.md)
- [Roadmap](docs/roadmap.md)

## Target Users

- EVE Online players who need fitting and loss intelligence
- Developers who want clean integration patterns around ESI and zKillboard

## Tech Stack

- Backend: ASP.NET Core Web API (.NET 10), C#
- Frontend: Next.js, React, TypeScript
- Integration: zKillboard API, EVE ESI API

## License

This project is open-source and available under the MIT License.
