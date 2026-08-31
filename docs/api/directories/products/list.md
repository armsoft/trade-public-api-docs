# Products - GetAll

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_producslist.htm)

## Description

Returns a list of products using complex filters.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/products/list`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

```json
{
  "showMode": "3",
  "group": "",
  "type": "",
  "codes": [""],
  "extended": true,
  "priceListTypes": ["01"],
  "lastModifiedDate": null,
  "pageSize": 5000
}
```

### Request body field notes

- `showMode` is required and can have 3 values:
  - `"1"` - Show products only in price list
  - `"2"` - Show products only not in price list
  - `"3"` - Show all
- `group` filters products by group code.
- `type` item type filter:
  - `"1"` - Products
  - `"2"` - Services
- `codes` list of product codes (example: `["1001", "1002"]`).
- `extended` shows extended information when `true`.
- `priceListTypes` includes prices by provided price list type codes (example: `"01"`, `"02"`).
- `lastModifiedDate` filters by last modification date when provided (example: `"2026-01-01T00:00:00Z"`).
- `pageSize` (optional) controls pagination:
  - `0` or omitted - Returns all products in a single response
  - `> 0` - Returns specified number of products per page; use pagination to access additional pages
  - See [Pagination](../../../pagination.md) for detailed pagination workflow

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

### Example response body

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "hasMore": true,
  "data": [
    {
      "typeName": "Ապրանք",
      "groupName": "Հեռուստացույցներ",
      "groupPath": "100!110",
      "labelUnitMeasureAbbreviation": "",
      "costingMethodName": "ՖԻՖՈ",
      "countryName": "",
      "producerName": "",
      "mainSupplierName": "",
      "substituteItemsGroupName": "",
      "lastModifierName": "",
      "creatorName": "",
      "prices": {},
      "id": 100000,
      "code": "1001",
      "name": "Հեռուստացույց LED Panasonic TX-LR55ET5",
      "fullName": "Հեռուստացույց LED Panasonic TX-LR55ET5",
      "type": "1",
      "cpaClassifier": "",
      "group": "110",
      "baseUnitMeasure": "001",
      "baseUnitMeasureAbbreviation": "հատ",
      "alternativeUnitMeasure": "002",
      "alternativeUnitMeasureAbbreviation": "տուփ",
      "barcode": "",
      "specification": "Smart VIERA LCD TV, Size: 55\" (140 cm), Full-HD",
      "externalCode": "",
      "costingMethod": "1",
      "vat": true,
      "checkMarking": false,
      "weight": false,
      "showInPriceLists": true,
      "environmentalFeePercent": 0,
      "labelUnitMeasure": "",
      "labelUnitMeasureCoefficient": 1.0,
      "country": "MY",
      "producer": "02",
      "property1": "",
      "property2": "",
      "minimumQuantity": 0,
      "maximumQuantity": 0,
      "addedValuePercent": 20.0,
      "aoeCoefficient": 1.0,
      "bonusPercent": 0,
      "bonusPoint": 0,
      "discountPercent": 0,
      "mainSupplierId": -1,
      "substituteItemsGroup": "",
      "nameEN": "",
      "nameRU": "",
      "additionalSpecification1": "",
      "additionalSpecification2": ""
    },
    {
      "typeName": "Ապրանք",
      "groupName": "Հեռուստացույցներ",
      "groupPath": "100!110",
      "labelUnitMeasureAbbreviation": "",
      "costingMethodName": "ՖԻՖՈ",
      "countryName": "",
      "producerName": "",
      "mainSupplierName": "",
      "substituteItemsGroupName": "",
      "lastModifierName": "",
      "creatorName": "",
      "prices": {},
      "id": 100001,
      "code": "1002",
      "name": "Հեռուստացույց LED SONY KDL-55W905ABAEP",
      "fullName": "Հեռուստացույց LED SONY KDL-55W905ABAEP",
      "type": "1",
      "cpaClassifier": "",
      "group": "110",
      "baseUnitMeasure": "001",
      "baseUnitMeasureAbbreviation": "հատ",
      "alternativeUnitMeasure": "001",
      "alternativeUnitMeasureAbbreviation": "հատ",
      "barcode": "",
      "specification": "Edge LED TV , Size: 55\" (140 cm), Full HD",
      "externalCode": "",
      "costingMethod": "1",
      "vat": true,
      "checkMarking": false,
      "weight": false,
      "showInPriceLists": true,
      "environmentalFeePercent": 0,
      "labelUnitMeasure": "",
      "labelUnitMeasureCoefficient": 1.0,
      "country": "TW",
      "producer": "01",
      "property1": "",
      "property2": "",
      "minimumQuantity": 0,
      "maximumQuantity": 0,
      "addedValuePercent": 0,
      "aoeCoefficient": 1.0,
      "bonusPercent": 0,
      "bonusPoint": 0,
      "discountPercent": 0,
      "mainSupplierId": -1,
      "substituteItemsGroup": "",
      "nameEN": "",
      "nameRU": "",
      "additionalSpecification1": "",
      "additionalSpecification2": ""
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/trade/v1/directories/products/list" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{ "showMode": "3" }'
```

## Pagination

This endpoint supports pagination through the `pageSize` parameter. See [Pagination](../../../pagination.md) for complete documentation on handling paginated responses.

### Pagination example

**Request (Page 1 with pageSize=10):**

```bash
curl -X POST "https://api.armsoft.am/trade/v1/directories/products/list" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{
    "showMode": "3",
    "pageSize": 5000
  }'
```

**Request (Subsequent Page):**

```bash
curl -X POST "https://api.armsoft.am/trade/v1/directories/products/list/nextpage" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{
    "id": "550e8400-e29b-41d4-a716-446655440000",
    "close": false
  }'
```

When `hasMore` is `false` in the response, all rows have been retrieved. To stop pagination before reaching the end, send a request with `"close": true`.
