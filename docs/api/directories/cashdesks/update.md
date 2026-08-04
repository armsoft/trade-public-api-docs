# Cash Desks - Update

## Description

Updates an existing cash desk identified by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `PUT`
- **Route:** `/v1/directories/cashdesks/{code}`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Cash desk code to update |

## Request body (example)

```json
{
  "code": "CD003",
  "name": "Updated Desk Name",
  "nextSaleNumber": "3005",
  "default": false,
  "ecr": true,
  "cashLimit": "150000",
  "isClosed": false
}
```

`CashDesk` object.

### Body field notes

- `isClosed` (optional, boolean) – set to `true` to mark the cash desk as closed, `false` to reopen it.
  Closed cash desks are hidden from `GET /v1/directories/cashdesks` when the request is sent with
  `showAlsoClosed=false`.

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the updated `CashDesk` object.
