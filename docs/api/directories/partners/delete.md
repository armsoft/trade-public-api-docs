# Partners - Delete

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_partners.htm)

## Description

Permanently deletes a partner.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `DELETE`
- **Route:** `/v1/directories/partners/{code}`
- **Authorization:** API key in header `apiKey`

## Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Partner code |

## Successful response

- **Status:** `200 OK`

The response body is empty.
