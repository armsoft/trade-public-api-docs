# Products - Create

## Description

Creates a product.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/products`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body

`Product` object.

## Notes

If `code` is empty, the server generates the next product code.

## Successful response

- **Status:** `201 Created`
- **Content type:** `application/json`

Returns the created `Product` object.
