# Documents - Products Movement

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_productsmovement.htm)

## Description

Creates and manages products movement documents.

## Endpoints

- **POST** `/v1/documents/productsmovement` — Create products movement
- **GET** `/v1/documents/productsmovement/{isn}` — Get by ISN
- **PUT** `/v1/documents/productsmovement/{isn}` — Update products movement
- **DELETE** `/v1/documents/productsmovement/{isn}` — Delete products movement

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
curl -X POST "https://api.armsoft.am/trade/v1/documents/productsmovement" \
  -H "accept: application/json" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"documentDate":"2026-03-01","fromStorage":"S001","toStorage":"S002","lines":[{"itemCode":"1001","quantity":2}]}'
```

## Response

- **201 Created** returns created products movement object.

### Example response

```json
{
  "isn": "550e8400-e29b-41d4-a716-446655440003",
  "date": "2026-03-01",
  "fromStorage": "S001",
  "toStorage": "S002",
  "lines": [
    { "itemCode": "1001", "quantity": 2 }
  ]
}
```
