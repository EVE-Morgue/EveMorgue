# Architecture

## Overview

`EveMorgue` follows a Clean Architecture structure to preserve separation of concerns and support long-term evolution.

```plaintext
apps/server/EVEMorgue.API   ASP.NET Core Web API entry point (HTTP concerns)
apps/server/EVEMorgue.Core  Application and domain logic
apps/client                 Next.js web experience
```

## Layer Responsibilities

### `.API`

- Exposes HTTP endpoints
- Handles request/response orchestration
- Delegates business workflows to `.Core`
- Lives at `apps/server/EVEMorgue.API`

### `.Core`

- Contains domain entities and use cases
- Encapsulates business rules
- Defines abstractions for infrastructure access
- Lives at `apps/server/EVEMorgue.Core`

### `.Client`

- Provides the user-facing website
- Implements search, filtering, and detail views
- Calls backend endpoints from `.API`
- Lives at `apps/client`

## Key Design Decisions

- **Clean boundaries first**: Keep business rules independent of transport/UI concerns.
- **Performance as a product feature**: Use parallelism, caching, and controlled concurrency for external APIs.
- **Docs-first communication**: Keep details in `docs/` and keep repository root concise.

## Performance Characteristics

- Parallel killmail retrieval (`Task.WhenAll`)
- In-memory caching (`MemoryCache`)
- Concurrency control (`SemaphoreSlim`)
- Reduced upstream API pressure through request shaping
