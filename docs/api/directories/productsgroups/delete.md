# Product Groups - Delete

## Description

Removes a product group by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `DELETE`
- **Route:** `/v1/directories/productsgroups/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Product group code to delete |

## Successful response

- **Status:** `204 No Content`

The object will be permanently removed from the directory.
