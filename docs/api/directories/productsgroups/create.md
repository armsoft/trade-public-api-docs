# Product Groups - Create

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_productsgroups.htm)

## Description

Creates a new product group entry.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/productsgroups`
- **Authorization:** API key in header `apiKey`

### Body parameters

Accepts a `ProductsGroup` object in JSON format.

```json
{
  "code": "PG110",
  "name": "Televisions",
  "parent": "PG100",
  "path": "PG100!PG110"
}
```

## Successful response

- **Status:** `201 Created`
- **Content type:** `application/json`

Returns the created object with the same structure.
