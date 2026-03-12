# Barcodes - GetAll

## Description

Returns a list of barcodes using simple filters.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/barcodes/list`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

```json
{
  "itemCodes": ["1001","1002"],
  "pageSize": 1000
}
```

### Request body field notes

- `itemCodes` filters by product codes associated with each barcode.
- `pageSize` (optional) controls pagination:
  - `0` or omitted – all rows in one response
  - `> 0` – return specified number per page; see [Pagination](../../pagination.md)

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `BarcodeApiResponse` object containing paging metadata and an array of barcode records.

### Sample response

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "hasMore": true,
  "data": [
    {
      "code": "ABC123",
      "itemId": 100,
      "itemCode": "100",
      "itemName": "Widget",
      "unitMeasure": "001",
      "unitMeasureAbbreviation": "pcs",
      "weightItem": false
    }
  ]
}
```

## Pagination

This endpoint supports pagination via the `pageSize` parameter. See [Pagination](../../pagination.md) for details.

### Pagination example

**Request (Page 1):**

```bash
curl -X POST "https://api.armsoft.am/trade/v1/directories/barcodes/list" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{ "pageSize": 500 }'
```

### Next page

When the response includes `hasMore: true`, send a request to the `nextpage` endpoint with the `id` token from the prior response. The body is a `NextPageRequest`.

```json
{ "id": "550e8400-e29b-41d4-a716-446655440000" }
```

Responses from `/list/nextpage` use the same format as above. Continue until `hasMore` becomes `false` or include `"close": true` to cancel.
