# Price List Types - Delete

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_pricelisttypes.htm)

## Description

Deletes a price list type by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `DELETE`
- **Route:** `/v1/directories/pricelisttypes/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Price list type code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json` (empty body)

The record is removed; no content returned.
