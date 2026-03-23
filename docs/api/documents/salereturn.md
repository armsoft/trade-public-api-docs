# Documents - Sale Return

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_salereturn.htm)

## Description

Creates and manages sale return documents.

## Endpoints

- **POST** `/v1/documents/salereturn` — Create sale return
- **GET** `/v1/documents/salereturn/{isn}` — Get sale return by ISN
- **PUT** `/v1/documents/salereturn/{isn}` — Update sale return
- **DELETE** `/v1/documents/salereturn/{isn}` — Delete sale return

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
curl -X POST "https://api.armsoft.am/trade/v1/documents/salereturn" \
  -H "accept: application/json" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"documentDate":"2026-03-01","partner":"P100","lines":[{"itemCode":"1001","quantity":1,"price":250}]}'
```

## Response

- **201 Created** returns created sale return object.

### Example response

```json
{
  "isn": "550e8400-e29b-41d4-a716-446655440005",
  "date": "2026-03-01",
  "partner": "P100",
  "lines": [
    { "itemCode": "1001", "quantity": 1, "price": 250 }
  ]
}
```