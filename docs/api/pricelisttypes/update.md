# Price List Types - Update

## Description

Replaces an existing price list type.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `PUT`
- **Route:** `/v1/directories/pricelisttypes/{code}`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Price list type code |

## Request body (example)

```json
{
  "code": "03",
  "name": "Export Updated",
  "currency": "EUR",
  "roundingDegree": "0.05",
  "includingVAT": true
}
```

`PriceListType` object.

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the updated `PriceListType` object.
