# Documents - Products Stocktaking

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_productsstocktaking.htm)

## Description

Creates and manages products stocktaking (inventory count) documents. Each row compares the
registered (book) quantity and amount of a product in a storage with the actually counted ones.

## Endpoints

- **POST** `/v1/documents/productsstocktaking` — Create products stocktaking
- **GET** `/v1/documents/productsstocktaking/{isn}` — Get by ISN
- **PUT** `/v1/documents/productsstocktaking/{isn}` — Update products stocktaking
- **DELETE** `/v1/documents/productsstocktaking/{isn}` — Delete products stocktaking

## Fields

Schema: `ProductsStockTaking`

| Field | Type | Description |
|-------|------|-------------|
| `isn` | string (uuid) | Document ISN. Optional on create; ignored on update (the route ISN is used) |
| `date` | string (date), nullable | Date. Defaults to today when omitted |
| `documentNumber` | string, nullable | Document N |
| `state` | integer | State. `1` saves the document as a draft; any other value saves it as processed (`2`) |
| `storage` | string, nullable | Storage. Left unchanged when empty |
| `productGroup` | string, nullable | Product's group |
| `currency` | string, nullable | Currency. Left unchanged when empty |
| `currencyExchangeRate` | number | Currency exchange rate |
| `currencyExchangeBase` | number | Currency exchange rate base |
| `priceListType` | string, nullable | Pricelist type |
| `comment` | string, nullable | Comment |
| `owner` | string, nullable | Owner. Left unchanged when empty |
| `itemList` | array of `ProductsStockTakingSpecificationRow`, nullable | Items list. When a non-empty list is sent it replaces the stored rows |

### Item row

Schema: `ProductsStockTakingSpecificationRow`

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Inner number |
| `code` | string, nullable | Code of the product |
| `name` | string, nullable | Name. Read-only |
| `unit` | string, nullable | Unit |
| `unitAbbreviation` | string, nullable | Abbreviation. Read-only |
| `registeredQuantity` | number | Registered quantity. Read-only |
| `actualQuantity` | number | Actual quantity |
| `variance` | number | Variance. Read-only |
| `registeredAmount` | number | Registered amount. Read-only |
| `price` | number, nullable | Price |
| `actualAmount` | number, nullable | Actual amount |
| `salePrice` | number, nullable | Sale price |
| `saleAmount` | number, nullable | Sale amount |
| `rowNumber` | integer | Line N. Read-only |

## Create request example

```json
{
  "date": "2026-11-09",
  "state": 2,
  "storage": "01",
  "currency": "AMD",
  "currencyExchangeRate": 1,
  "currencyExchangeBase": 1,
  "comment": "Year-end count",
  "itemList": [
    { "code": "1001", "unit": "pcs", "actualQuantity": 48, "price": 250, "actualAmount": 12000 },
    { "code": "1002", "unit": "pcs", "actualQuantity": 100, "price": 300, "actualAmount": 30000 }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/trade/v1/documents/productsstocktaking" \
  -H "accept: application/json" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date":"2026-11-09","state":2,"storage":"01","currency":"AMD","currencyExchangeRate":1,"currencyExchangeBase":1,"itemList":[{"code":"1001","unit":"pcs","actualQuantity":48,"price":250,"actualAmount":12000}]}'
```

## Response

- **201 Created** returns the created products stocktaking document.
- **GET** and **PUT** return **200 OK** with the document; **DELETE** returns **200 OK** with no body.

### Example response

```json
{
  "isn": "550e8400-e29b-41d4-a716-446655440011",
  "date": "2026-11-09",
  "documentNumber": "7",
  "state": 2,
  "storage": "01",
  "productGroup": null,
  "currency": "AMD",
  "currencyExchangeRate": 1,
  "currencyExchangeBase": 1,
  "priceListType": null,
  "comment": "Year-end count",
  "owner": "admin",
  "itemList": [
    {
      "id": 101,
      "code": "1001",
      "name": "Gift box",
      "unit": "pcs",
      "unitAbbreviation": "pcs",
      "registeredQuantity": 50,
      "actualQuantity": 48,
      "variance": -2,
      "registeredAmount": 12500,
      "price": 250,
      "actualAmount": 12000,
      "salePrice": 0,
      "saleAmount": 0,
      "rowNumber": 1
    }
  ]
}
```
