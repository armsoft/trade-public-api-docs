# Reports - Products Balances Short

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_productsbalancesshort.htm)

## Description

Returns short product balances report for a date and filters.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/productsbalances/short`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

```json
{
  "date": "2026-02-01",
  "pageSize": 1000,
  "showZeroRows": false
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/trade/v1/reports/productsbalances/short" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date":"2026-02-01","pageSize":1000,"showZeroRows":false}'
```
