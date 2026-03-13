# Product Groups - Update

## Description

Updates an existing product group.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `PUT`
- **Route:** `/v1/directories/productsgroups/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Product group code to update |

### Body parameters

A `ProductsGroup` object with updated fields.

```json
{
  "code": "PG110",
  "name": "Smart TVs",
  "parent": "PG100",
  "path": "PG100!PG110"
}
```

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the updated object.
