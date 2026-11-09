# Documents - Products Kitting

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_documents.htm)

## Description

Creates and manages products kitting documents. A kitting document assembles a quantity of a kit
from its components: the components are written off from the output storage and the kit is
received into the input storage.

## Endpoints

- **POST** `/v1/documents/productskitting` — Create products kitting
- **GET** `/v1/documents/productskitting/{isn}` — Get by ISN
- **PUT** `/v1/documents/productskitting/{isn}` — Update products kitting
- **DELETE** `/v1/documents/productskitting/{isn}` — Delete products kitting

## Fields

Schema: `ProductsKitting`

| Field | Type | Description |
|-------|------|-------------|
| `isn` | string (uuid) | Document ISN. Optional on create; ignored on update (the route ISN is used) |
| `date` | string (date), nullable | Date. Defaults to today when omitted |
| `documentNumber` | string, nullable | Document N |
| `state` | integer | State. `1` saves the document as a draft; any other value saves it as processed (`2`) |
| `storageOutput` | string, nullable | Storage output — storage the components are written off from. Left unchanged when empty |
| `storageInput` | string, nullable | Storage input — storage the kit is received into |
| `kit` | string, nullable | Kit — product code of the kit |
| `unit` | string, nullable | Unit of the kit quantity |
| `quantity` | number, nullable | Quantity of kits |
| `expirationDate` | string (date), nullable | Exp. date |
| `country` | string, nullable | Country |
| `producer` | string, nullable | Producer |
| `property1` | string, nullable | Property 1 |
| `property2` | string, nullable | Property 2 |
| `comment` | string, nullable | Comment |
| `owner` | string, nullable | Owner. Left unchanged when empty |
| `totalAmount` | number, nullable | Total amount. Read-only |
| `kitComponents` | array of `ProductsKittingSpecificationRow`, nullable | Kit's components. When a non-empty list is sent it replaces the stored components |

### Kit component row

Schema: `ProductsKittingSpecificationRow`

| Field | Type | Description |
|-------|------|-------------|
| `type` | string, nullable | Type. Read-only |
| `id` | integer, nullable | Inner number. Read-only |
| `code` | string, nullable | Code of the component |
| `name` | string, nullable | Name. Read-only |
| `unit` | string, nullable | Unit |
| `unitAbbreviation` | string, nullable | Abbreviation. Read-only |
| `quantity` | number, nullable | Quantity |
| `amount` | number, nullable | Amount |
| `rowNumber` | integer | Line N. Read-only |
| `rowId` | integer, nullable | Lines ID. Read-only |

## Create request example

```json
{
  "date": "2026-11-09",
  "state": 2,
  "storageOutput": "01",
  "storageInput": "01",
  "kit": "K001",
  "unit": "pcs",
  "quantity": 10,
  "comment": "Gift box assembly",
  "kitComponents": [
    { "code": "1001", "unit": "pcs", "quantity": 10 },
    { "code": "1002", "unit": "pcs", "quantity": 20 }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/trade/v1/documents/productskitting" \
  -H "accept: application/json" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date":"2026-11-09","state":2,"storageOutput":"01","storageInput":"01","kit":"K001","unit":"pcs","quantity":10,"kitComponents":[{"code":"1001","unit":"pcs","quantity":10},{"code":"1002","unit":"pcs","quantity":20}]}'
```

## Response

- **201 Created** returns the created products kitting document.
- **GET** and **PUT** return **200 OK** with the document; **DELETE** returns **200 OK** with no body.

### Example response

```json
{
  "isn": "550e8400-e29b-41d4-a716-446655440010",
  "date": "2026-11-09",
  "documentNumber": "15",
  "state": 2,
  "storageOutput": "01",
  "storageInput": "01",
  "kit": "K001",
  "unit": "pcs",
  "quantity": 10,
  "expirationDate": null,
  "country": null,
  "producer": null,
  "property1": null,
  "property2": null,
  "comment": "Gift box assembly",
  "owner": "admin",
  "totalAmount": 8500,
  "kitComponents": [
    { "type": "1", "id": 101, "code": "1001", "name": "Gift box", "unit": "pcs", "unitAbbreviation": "pcs", "quantity": 10, "amount": 2500, "rowNumber": 1, "rowId": 0 },
    { "type": "1", "id": 102, "code": "1002", "name": "Chocolate bar", "unit": "pcs", "unitAbbreviation": "pcs", "quantity": 20, "amount": 6000, "rowNumber": 2, "rowId": 1 }
  ]
}
```
