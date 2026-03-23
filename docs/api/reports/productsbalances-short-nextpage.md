# Reports - Products Balances Short (Next Page)

## Description

Retrieves the next page for products balances short report.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/productsbalances/short/nextpage`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "close": false
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/trade/v1/reports/productsbalances/short/nextpage" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"id":"550e8400-e29b-41d4-a716-446655440000","close":false}'
```
