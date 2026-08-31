# Partners Groups - Delete

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_partnersgroups.htm)

## Description

Deletes a partner group by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `DELETE`
- **Route:** `/v1/directories/partnersgroups/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Partner group code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json` (empty)

The record is removed; the body is empty.
