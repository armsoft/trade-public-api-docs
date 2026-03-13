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
  "address": "1000 Market St",
  "phone": "555-0111"
}
```

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the updated object.
