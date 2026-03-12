# Partners - GetAll

## Description

Returns a list of partners using complex filters.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/partners/list`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

```json
{
  "codes": ["P001","P002"],
  "group": "",
  "extended": true,
  "lastModifiedDate": null,
  "pageSize": 5000
}
```

### Request body field notes

- `codes` filters by partner codes.
- `group` filters by partner group code.
- `extended` when `true` includes additional partner fields.
- `lastModifiedDate` returns records changed after the given timestamp.
- `pageSize` (optional) controls pagination:
  - `0` or omitted – all rows in one response
  - `> 0` – return specified number per page; see [Pagination](../../pagination.md)

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `PartnerRowApiResponse` object containing paging metadata and an array of partners.

## Usage example

```bash
curl -X POST "https://api.armsoft.am/trade/v1/directories/partners/list" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{ "extended": true }'
```

## Pagination

This endpoint supports pagination via the `pageSize` parameter. See [Pagination](../../pagination.md) for details.

### Pagination example

**Request (Page 1):**

```bash
curl -X POST "https://api.armsoft.am/trade/v1/directories/partners/list" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{ "extended": true, "pageSize": 5000 }'
```

### Next page

When the response contains `hasMore: true` the server returns an `id` token. Use the
`/v1/directories/partners/list/nextpage` endpoint with a `NextPageRequest` body:

```json
{ "id": "550e8400-e29b-41d4-a716-446655440000" }
```

The reply uses the same `PartnerRowApiResponse` format. Continue calling until
`hasMore` becomes `false`, or specify `"close": true` to cancel further pages.

### Sample response

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "hasMore": true,
  "data": [
    {
      "id": 1,
      "code": "P001",
      "name": "Partner 1",
      "fullName": "Partner One LLC",
      "taxCode": "123456789",
      "group": "G001",
      "supplier": true,
      "customer": false
    }
  ]
}
```