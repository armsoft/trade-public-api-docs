# Journals - All Documents

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_alldocuments.htm)

## Description

Returns documents journal rows by date range and optional filters.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/journals/alldocuments`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

```json
{
  "startDate": "2026-01-01",
  "endDate": "2026-01-31",
  "pageSize": 5000,
  "currency": "AMD",
  "partnerCode": "P100"
}
```

### Request body field notes

- `startDate` (required) - Journal start date.
- `endDate` (required) - Journal end date.
- `pageSize` - Pagination page size.
- `documentTypes` - Filter by document types.
- `partnerCode` - Partner code filter.
- `itemCode` - Item code filter.
- `documentState` - Document state.
- `owner` - Owner filter.

## Usage example

```bash
curl -X POST "https://api.armsoft.am/trade/v1/journals/alldocuments" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"startDate":"2026-01-01","endDate":"2026-01-31","pageSize":1000}'
```
