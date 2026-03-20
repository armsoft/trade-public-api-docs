# Documents - Invoice

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_invoice.htm)

## Description

Creates or retrieves invoices.

## Endpoints

- **POST** `/v1/documents/invoice` — Create invoice
- **GET** `/v1/documents/invoice/{isn}` — Get invoice by ISN
- **PUT** `/v1/documents/invoice/{isn}` — Update invoice
- **DELETE** `/v1/documents/invoice/{isn}` — Delete invoice

## Required fields

- `documentDate` (YYYY-MM-DD)
- `customer` or `partner`
- `lines` (non-empty list)

## Create request example

```json
{
  "documentDate": "2026-03-01",
  "customer": "P100",
  "lines": [
    { "itemCode": "1001", "quantity": 2, "price": 200 }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/trade/v1/documents/invoice" \
  -H "accept: application/json" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"documentDate":"2026-03-01","partner":"P100","lines":[{"itemCode":"1001","quantity":2,"price":200}]}'
```
## Response

- **201 Created** returns created invoice object with `isn`, `date`, and line totals.

### Example response

```json
{
  "isn": "550e8400-e29b-41d4-a716-446655440000",
  "date": "2026-03-01",
  "documentNumber": "INV-2026-1001",
  "customer": "P100",
  "lines": [
    { "itemCode": "1001", "quantity": 2, "price": 200 }
  ]
}
```