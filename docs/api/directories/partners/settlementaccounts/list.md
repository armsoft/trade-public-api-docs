# `POST /v1/directories/partners/settlementaccounts/list`

Returns partner settlement account details with pagination.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/partners/settlementaccounts/list`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Headers

- `apiKey`: `YOUR_API_KEY`
- `Accept-Language`: `en-US` (or `hy-AM`, `ru-RU`)
- `Content-Type`: `application/json`

## Request body (example)

```json
{
  "pageSize": 5000,
  "partnerCodes": ["PARTNER001", "PARTNER002"]
}
```

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a paged list of partner settlement accounts.

### Example response

```json
{
  "id": "9b4f1b5b-5f9d-4c2e-95f6-2f5c0b5c3d7a",
  "hasMore": true,
  "data": [
    {
      "partnerId": 1,
      "partnerCode": "PARTNER001",
      "partnerName": "Example Partner LLC",
      "settlementAccount": "AM0012345678901234567890",
      "name": "Main bank account",
      "default": true
    }
  ]
}
```
