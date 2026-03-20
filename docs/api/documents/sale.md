# Documents - Sale

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_docsale.htm)

## Description

Creates and manages sale documents.

## Endpoints

- **POST** `/v1/documents/sale` — Create sale
- **GET** `/v1/documents/sale/{isn}` — Get sale by ISN
- **PUT** `/v1/documents/sale/{isn}` — Update sale
- **DELETE** `/v1/documents/sale/{isn}` — Delete sale

## Required fields

- `documentDate` (YYYY-MM-DD)
- `partner`
- `lines` (non-empty list)

## Create request example

```json
{
  "documentDate": "2026-03-01",
  "partner": "P100",
  "lines": [
    { "itemCode": "1001", "quantity": 1, "price": 250 }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/trade/v1/documents/sale" \
  -H "accept: application/json" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"documentDate":"2026-03-01","partner":"P100","lines":[{"itemCode":"1001","quantity":1,"price":250}]}'
```

## Response

- **201 Created** returns created sale object.

### Example response

```json
{
  "isn": "550e8400-e29b-41d4-a716-446655440004",
  "date": "2026-03-01",
  "partner": "P100",
  "lines": [
    { "itemCode": "1001", "quantity": 1, "price": 250 }
  ]
}
```
