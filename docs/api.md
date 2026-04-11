# API Reference

> This API is currently used by the website and may be exposed as a public API in future versions.

Base path examples are shown relative to the API host.

## Endpoints

### 1. Search Losses

`GET /api/search?shipId={shipId}&itemId={itemId}`

Returns killmails where the requested item appears in the ship fitting.

#### Example Request

`GET /api/search?shipId=587&itemId=12761`

#### Example Response (shape)

```json
{
  "shipId": 587,
  "itemId": 12761,
  "results": [
    {
      "killmailId": 123456789,
      "killmailHash": "example_hash",
      "matchedItem": true
    }
  ]
}
```

### 2. Search Ships

`GET /api/ships/search?keyword={keyword}`

Returns ships matching a keyword.

#### Example Request

`GET /api/ships/search?keyword=rav`

#### Example Response (shape)

```json
[
  { "shipId": 638, "name": "Raven" },
  { "shipId": 645, "name": "Raven Navy Issue" }
]
```

### 3. Ship Details

`GET /api/ships/{shipId}`

Returns details for a single ship.

#### Example Request

`GET /api/ships/638`

#### Example Response (shape)

```json
{
  "shipId": 638,
  "name": "Raven",
  "description": "Battleship",
  "group": "Battleship",
  "attributes": []
}
```

## External Data Providers

- zKillboard: `https://zkillboard.com/api/shipID/{shipID}/losses/`
- ESI: `https://esi.evetech.net/`

## Versioning Notes

When public API support is introduced, endpoint versioning and compatibility guarantees will be documented here.
