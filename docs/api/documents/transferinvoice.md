# Documents - Transfer Invoice

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_transferinvoice.htm)

## Description

Creates and manages transfer invoices.

## Endpoints

- **POST** `/v1/documents/transferinvoice` — Create transfer invoice
- **GET** `/v1/documents/transferinvoice/{isn}` — Get transfer invoice by ISN
- **PUT** `/v1/documents/transferinvoice/{isn}` — Update transfer invoice
- **DELETE** `/v1/documents/transferinvoice/{isn}` — Delete transfer invoice

## Required fields

- `documentDate` (YYYY-MM-DD)
- `fromStorage`
- `toStorage`
- `lines` (non-empty list)

## Create request example

```json
{
  "documentDate": "2026-03-01",
  "fromStorage": "S001",
  "toStorage": "S002",
  "lines": [
    { "itemCode": "1001", "quantity": 2 }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/trade/v1/documents/transferinvoice" \
  -H "accept: application/json" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"documentDate":"2026-03-01","fromStorage":"S001","toStorage":"S002","lines":[{"itemCode":"1001","quantity":2}]}'
```

## Response

- **201 Created** returns created transfer invoice object.

### Example response

```json
{
  "isn": "550e8400-e29b-41d4-a716-446655440006",
  "date": "2026-03-01",
  "fromStorage": "S001",
  "toStorage": "S002",
  "lines": [
    { "itemCode": "1001", "quantity": 2 }
  ]
}
```
