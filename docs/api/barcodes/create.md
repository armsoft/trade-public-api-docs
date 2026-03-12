# Barcodes - Create

## Description

Creates a new barcode record.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/barcodes`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

```json
{
  "code": "ABC123",
  "itemId": 100,
  "itemCode": "100",
  "itemName": "Widget",
  "unitMeasure": "001",
  "unitMeasureAbbreviation": "pcs",
  "weightItem": false
}
```

`Barcode` object.

## Successful response

- **Status:** `201 Created`
- **Content type:** `application/json`

Returns the created `Barcode` object.
