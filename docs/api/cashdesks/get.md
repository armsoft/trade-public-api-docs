# Cash Desks - Get

## Description

Retrieves a single cash desk by its code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/cashdesks/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Cash desk code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the `CashDesk` object.

### Example

```json
{
  "code": "CD001",
  "name": "Main Cash Desk",
  "nextSaleNumber": "1001",
  "default": true,
  "ecr": false,
  "cashLimit": "500000"
}
```
