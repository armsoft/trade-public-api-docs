# Documents - Storage Input Order

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_storageinputorder.htm)

## Description

Creates and manages storage input orders.

## Endpoints

- **POST** `/v1/documents/storageinputorder` — Create storage input order
- **GET** `/v1/documents/storageinputorder/{isn}` — Get by ISN
- **PUT** `/v1/documents/storageinputorder/{isn}` — Update storage input order
- **DELETE** `/v1/documents/storageinputorder/{isn}` — Delete storage input order

## Required fields

- `documentDate` (YYYY-MM-DD)
- `storage`
- `lines` (non-empty list)

## Create request example

```json
{
  "documentDate": "2026-03-01",
  "storage": "S001",
  "lines": [
    { "itemCode": "1001", "quantity": 5, "price": 100 }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/trade/v1/documents/storageinputorder" \
  -H "accept: application/json" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"documentDate":"2026-03-01","storage":"S001","lines":[{"itemCode":"1001","quantity":5,"price":100}]}'
```

## Response

- **201 Created** returns created storage input order object with `isn` and totals.

### Example response

```json
{
  "isn": "550e8400-e29b-41d4-a716-446655440001",
  "date": "2026-03-01",
  "storage": "S001",
  "productsList": [
    { "itemCode": "1001", "quantity": 5, "price": 100 }
  ]
}
```
