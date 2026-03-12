# Product Groups - Get

## Description

Retrieves a product group by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/productsgroups/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Product group code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the `ProductsGroup` object.

### Example

```json
{ "code": "PG110", "name": "Televisions", "parent": "PG100", "path": "PG100!PG110" }
```