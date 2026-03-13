# Products - Update

## Description

Updates a product by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `PUT`
- **Route:** `/v1/directories/products/{code}`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Product code |

## Request body

`Product` object.

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the updated `Product` object.
