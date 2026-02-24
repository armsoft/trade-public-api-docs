# Products - Get

## Description

Returns one product by product code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade`
- **Method:** `GET`
- **Route:** `/v1/directories/products/{code}`
- **Authorization:** API key in header `apiKey`

## Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Product code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `Product` object.
