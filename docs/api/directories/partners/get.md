# Partners - Get

## Description

Returns one partner by partner code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/partners/{code}`
- **Authorization:** API key in header `apiKey`

## Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Partner code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `Partner` object.
