# Barcodes - Next Page

## Description

Fetches the next page of results for a previously executed `/list` request. Use when the initial list call returned `hasMore: true`.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/barcodes/list/nextpage`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body

`NextPageRequest` object, for example:

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000"
}
```

Optionally include `"close": true` when you no longer need additional pages.

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the same `BarcodeApiResponse` format as the initial `/list` call.
