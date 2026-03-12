# Storages - Get

## Description

Retrieve storage information by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/storages/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Storage code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `Storage` object.

### Example

```json
{
  "code": "ST001",
  "name": "Main Warehouse",
  "address": "1000 Market St",
  "phone": "555-0100"
}
```