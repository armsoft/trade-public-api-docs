# Partners Groups - Get

## Description

Retrieves a partner group by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/partnersgroups/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Partner group code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the `PartnersGroup` object.

### Example

```json
{ "code": "PG001", "name": "Wholesale", "parent": "", "path": "PG001" }
```
