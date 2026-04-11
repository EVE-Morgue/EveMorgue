# Architecture

## Overview

`EveMorgue` follows a Clean Architecture structure to preserve separation of concerns and support long-term evolution.

```plaintext
.API     ASP.NET Core Web API entry point (HTTP concerns)
.Core    Application and domain logic
.Client  Next.js web experience
```

## Layer Responsibilities

### `.API`
- Exposes HTTP endpoints
- Handles request/response orchestration
- Delegates business workflows to `.Core`

### `.Core`
- Contains domain entities and use cases
- Encapsulates business rules
- Defines abstractions for infrastructure access

### `.Client`
- Provides the user-facing website
- Implements search, filtering, and detail views
- Calls backend endpoints from `.API`

## Key Design Decisions

- **Clean boundaries first**: Keep business rules independent of transport/UI concerns.
- **Performance as a product feature**: Use parallelism, caching, and controlled concurrency for external APIs.
- **Docs-first communication**: Keep details in `docs/` and keep repository root concise.

## Performance Characteristics

- Parallel killmail retrieval (`Task.WhenAll`)
- In-memory caching (`MemoryCache`)
- Concurrency control (`SemaphoreSlim`)
- Reduced upstream API pressure through request shaping
