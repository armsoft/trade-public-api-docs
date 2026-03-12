# Price List Types - Get

## Description

Retrieves a price list type by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/pricelisttypes/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Price list type code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the `PriceListType` object.

### Example

```json
{ "code": "01", "name": "Retail", "currency": "AMD", "roundingDegree": "0.01", "includingVAT": true }
```
