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

### Response field notes

- `isClosed` – `true` when the partner is closed (no longer in active use). A closed partner is still
  returned by this endpoint; the flag only affects [List Partners](list.md), where closed partners are
  included exclusively when `"showAlsoClosed": true` is sent.
