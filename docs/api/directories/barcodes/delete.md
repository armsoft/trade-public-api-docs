# Barcodes - Delete

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_barcodes.htm)

## Description

Deletes a barcode record by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `DELETE`
- **Route:** `/v1/directories/barcodes/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Barcode value to remove |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json` (empty body)

The record is removed; the response body is empty.
