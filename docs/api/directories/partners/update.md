# Partners - Update

## Description

Replaces all fields of an existing partner.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `PUT`
- **Route:** `/v1/directories/partners/{code}`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Partner code |

## Request body

`Partner` object.

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the updated `Partner` object.
