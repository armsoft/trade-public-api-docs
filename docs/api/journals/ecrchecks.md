# Journals - ECR Checks

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_ecrchecks.htm)

## Description

Returns ECR checks journal rows by date range and optional filters.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/journals/ecrchecks`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

```json
{
  "startDate": "2026-01-01",
  "endDate": "2026-01-31",
  "pageSize": 5000,
  "cashDeskCode": "CD001",
  "showPayments": true
}
```

### Request body notes

- `startDate` (required) - Journal start date.
- `endDate` (required) - Journal end date.
- `cashDeskCode` - Optional cash desk filter.
- `showPayments` - Include payments when true.

## Usage example

```bash
curl -X POST "https://api.armsoft.am/trade/v1/journals/ecrchecks" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"startDate":"2026-01-01","endDate":"2026-01-31","pageSize":1000}'
```
