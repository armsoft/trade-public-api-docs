# Storages - Update

## Description

Updates an existing storage record.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `PUT`
- **Route:** `/v1/directories/storages/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Storage code to update |

### Body parameters

A `Storage` object with updated values.

```json
{
  "code": "ST001",
  "name": "Main Warehouse - Updated",
  "stockkeeper": "John Smith",
  "address": "1000 Market St",
  "retail": false,
  "isClosed": false
}
```

### Body field notes

- `isClosed` (optional, boolean) – set to `true` to mark the storage as closed, `false` to reopen it.
  Closed storages are hidden from `GET /v1/directories/storages` when the request is sent with
  `showAlsoClosed=false`.

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the updated object.
