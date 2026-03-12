# Cash Desks - Create

## Description

Creates a new cash desk record.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/cashdesks`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

```json
{
  "code": "CD003",
  "name": "Tertiary Desk",
  "nextSaleNumber": "3001",
  "default": false,
  "ecr": false,
  "cashLimit": "100000"
}
```

`CashDesk` object.

## Successful response

- **Status:** `201 Created`
- **Content type:** `application/json`

Returns the created `CashDesk` object.
