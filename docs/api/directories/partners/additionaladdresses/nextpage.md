# `POST /v1/directories/partners/additionaladdresses/list/nextpage`

Returns the next page for additional addresses.

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_partnerssadditionaladdresseslist.htm)

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/partners/additionaladdresses/list/nextpage`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Headers

- `apiKey`: `YOUR_API_KEY`
- `Accept-Language`: `en-US` (or `hy-AM`, `ru-RU`)
- `Content-Type`: `application/json`

## Request body (example)

```json
{
  "id": "2c8f7f2a-6f53-4a8e-9b0f-760a2b8dcb67",
  "close": false
}
```

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the next page of additional addresses under the same paged result format.

### Example response

```json
{
  "id": "2c8f7f2a-6f53-4a8e-9b0f-760a2b8dcb67",
  "hasMore": false,
  "data": [
    {
      "partnerId": 1,
      "partnerCode": "PARTNER001",
      "partnerName": "Example Partner LLC",
      "businessAddress": "Yerevan, 1 Main St.",
      "default": true
    }
  ]
}
```