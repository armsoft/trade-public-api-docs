# Storages - Create

## Description

Create a new storage record.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/storages`
- **Authorization:** API key in header `apiKey`

### Body parameters

A `Storage` object:

```json
{
  "code": "ST002",
  "name": "Secondary Warehouse",
  "address": "2000 Industrial Rd",
  "phone": "555-0200"
}
```

## Successful response

- **Status:** `201 Created`
- **Content type:** `application/json`

Returns the created storage object.
