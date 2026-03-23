# Documents - Storage Input Order Retail

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_storageinputorderretail.htm)

## Description

Creates and manages retail storage input orders.

## Endpoints

- **POST** `/v1/documents/storageinputorderretail` — Create retail storage input order
- **GET** `/v1/documents/storageinputorderretail/{isn}` — Get by ISN
- **PUT** `/v1/documents/storageinputorderretail/{isn}` — Update retail storage input order
- **DELETE** `/v1/documents/storageinputorderretail/{isn}` — Delete retail order

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
    { "itemCode": "1001", "quantity": 3, "price": 150 }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/trade/v1/documents/storageinputorderretail" \
  -H "accept: application/json" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"documentDate":"2026-03-01","storage":"S001","lines":[{"itemCode":"1001","quantity":3,"price":150}]}'
```

## Response

- **201 Created** returns created storage input order retail object.

### Example response

```json
{
  "isn": "550e8400-e29b-41d4-a716-446655440002",
  "date": "2026-03-01",
  "storage": "S001",
  "lines": [
    { "itemCode": "1001", "quantity": 3, "price": 150 }
  ]
}
```
