# Partners Groups - Update

## Description

Updates an existing partner group by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `PUT`
- **Route:** `/v1/directories/partnersgroups/{code}`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Partner group code |

## Request body (example)

```json
{
  "code": "PG003",
  "name": "Online Retail",
  "parent": "PG002",
  "path": "PG002!PG003"
}
```

`PartnersGroup` object.

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the updated `PartnersGroup` object.
