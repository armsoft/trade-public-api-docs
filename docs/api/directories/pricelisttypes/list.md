# Price List Types - GetAll

## Description

Returns an array of price list types.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/pricelisttypes`
- **Authorization:** API key in header `apiKey`

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a list of `PriceListType` objects.

### Sample response

```json
[
  { "code": "01", "name": "Retail", "currency": "AMD", "roundingDegree": "0.01", "includingVAT": true },
  { "code": "02", "name": "Wholesale", "currency": "USD", "roundingDegree": "0.01", "includingVAT": false }
]
```
