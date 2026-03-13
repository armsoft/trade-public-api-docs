# Price List Types - Create

## Description

Creates a new price list type.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/pricelisttypes`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

```json
{
  "code": "03",
  "name": "Export",
  "currency": "EUR",
  "roundingDegree": "0.01",
  "includingVAT": false
}
```

`PriceListType` object.

## Successful response

- **Status:** `201 Created`
- **Content type:** `application/json`

Returns the created `PriceListType` object.
