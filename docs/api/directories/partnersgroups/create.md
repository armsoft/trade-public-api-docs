# Partners Groups - Create

## Description

Creates a new partner group.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/partnersgroups`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

```json
{
  "code": "PG003",
  "name": "Online",
  "parent": "PG001",
  "path": "PG001!PG003"
}
```

`PartnersGroup` object.

## Successful response

- **Status:** `201 Created`
- **Content type:** `application/json`

Returns the created `PartnersGroup` object.
