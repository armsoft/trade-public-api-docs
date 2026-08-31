# Storages - Create

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_storageslist.htm)

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
  "stockkeeper": "Ann Petrosyan",
  "address": "2000 Industrial Rd",
  "retail": false,
  "isClosed": false
}
```

### Body field notes

- `isClosed` (optional, boolean) – marks the storage as closed. Omit it or send `false` to create an
  active storage.

## Successful response

- **Status:** `201 Created`
- **Content type:** `application/json`

Returns the created storage object.
