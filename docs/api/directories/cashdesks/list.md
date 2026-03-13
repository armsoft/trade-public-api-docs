# Cash Desks - GetAll

## Description

Returns all cash desk records. There are no query parameters; the call simply
retrieves every cash desk in the system.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/cashdesks`
- **Authorization:** API key in header `apiKey`

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns an array of `CashDesk` objects.

### Sample response

```json
[
  {
    "code": "CD001",
    "name": "Main Cash Desk",
    "nextSaleNumber": "1001",
    "default": true,
    "ecr": false,
    "cashLimit": "500000"
  },
  {
    "code": "CD002",
    "name": "Secondary Desk",
    "nextSaleNumber": "2001",
    "default": false,
    "ecr": true,
    "cashLimit": "250000"
  }
]
```

## Usage example

```bash
curl "https://api.armsoft.am/trade/v1/directories/cashdesks" \
  -H "accept: application/json" \
  -H "apiKey: YOUR_API_KEY"
```
