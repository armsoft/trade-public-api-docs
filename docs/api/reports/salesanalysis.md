# Reports - Sales Analysis

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_salesanalysis.htm)

## Description

Returns sales analysis rows by date range and optional filters.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/salesanalysis`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

```json
{
  "startDate": "2026-01-01",
  "endDate": "2026-01-31",
  "pageSize": 1000
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/trade/v1/reports/salesanalysis" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"startDate":"2026-01-01","endDate":"2026-01-31","pageSize":1000}'
```
