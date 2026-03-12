# Product Groups - GetAll

## Description

Returns all product groups.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/productsgroups`
- **Authorization:** API key in header `apiKey`

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns an array of `ProductsGroup` objects.

### Sample response

```json
[
  { "code": "PG100", "name": "Electronics", "parent": "", "path": "PG100" },
  { "code": "PG110", "name": "Televisions", "parent": "PG100", "path": "PG100!PG110" }
]
```