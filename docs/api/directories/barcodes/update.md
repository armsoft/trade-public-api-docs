# Barcodes - Update

## Description

Replaces an existing barcode record with new values.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `PUT`
- **Route:** `/v1/directories/barcodes/{code}`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Barcode value to update |

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

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the updated `Barcode` object.
