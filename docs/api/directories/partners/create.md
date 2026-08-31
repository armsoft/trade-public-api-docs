# Partners - Create

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_partners.htm)

## Description

Creates a partner.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/partners`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body

`Partner` object.

### Body field notes

- `isClosed` (optional, boolean) – marks the partner as closed. Omit it or send `false` to create an
  active partner.

## Successful response

- **Status:** `201 Created`
- **Content type:** `application/json`

Returns the created `Partner` object.
