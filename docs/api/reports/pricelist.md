# Reports - Price List

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_pricelist.htm)

## Description

Returns price list data by date, price list types, and filters.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/pricelist`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

```json
{
  "date": "2026-02-01",
  "itemsShowMode": "1",
  "priceListTypes": ["01"],
  "pageSize": 1000
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/trade/v1/reports/pricelist" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date":"2026-02-01","itemsShowMode":"1","priceListTypes":["01"],"pageSize":1000}'
```
