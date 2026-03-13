# Partners Groups - GetAll

## Description

Returns all partner groups.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/partnersgroups`
- **Authorization:** API key in header `apiKey`

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns an array of `PartnersGroup` objects.

### Sample response

```json
[
  { "code": "PG001", "name": "Wholesale", "parent": "", "path": "PG001" },
  { "code": "PG002", "name": "Retail", "parent": "", "path": "PG002" }
]
```
