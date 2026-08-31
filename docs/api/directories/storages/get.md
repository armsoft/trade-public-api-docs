# Storages - Get

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_storageslist.htm)

## Description

Retrieves storage information.
- If **code is provided** → returns a single storage
- If **code is not provided** → returns all storages

## Endpoints

### 1. Get all storages

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/storages`
- **Authorization:** API key in header `apiKey`

#### Query parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| showAlsoClosed | boolean | No | `true` | When `true`, closed storages (`isClosed: true`) are returned together with the open ones. Pass `false` to return only storages that are not closed. |

### 2. Get storage by code

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/storages/{code}`
- **Authorization:** API key in header `apiKey`

#### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Storage code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `Storage` object when `code` is provided, otherwise an array of `Storage` objects.

### Example (single storage)

```json
{
  "code": "ST001",
  "name": "Main Warehouse",
  "stockkeeper": "John Smith",
  "address": "1000 Market St",
  "retail": false,
  "isClosed": false
}
```

### Example (all storages)

```json
[
  {
    "code": "ST001",
    "name": "Main Warehouse",
    "stockkeeper": "John Smith",
    "address": "1000 Market St",
    "retail": false,
    "isClosed": false
  },
  {
    "code": "ST002",
    "name": "Closed Warehouse",
    "stockkeeper": "Ann Petrosyan",
    "address": "2000 Industrial Rd",
    "retail": false,
    "isClosed": true
  }
]
```

## Response field notes

- `isClosed` – `true` when the storage is closed (no longer in active use). Closed storages are
  included in the list response unless `showAlsoClosed=false` is passed.

## Usage example

```bash
# only storages that are not closed
curl -X GET "https://api.armsoft.am/trade/v1/directories/storages?showAlsoClosed=false" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY"
```
