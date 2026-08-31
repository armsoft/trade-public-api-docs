# Barcodes - Get

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_barcodes.htm)

## Description

Retrieves a barcode record by its code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/barcodes/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Barcode value |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the `Barcode` object.
