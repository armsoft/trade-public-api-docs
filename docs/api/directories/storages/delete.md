# Storages - Delete

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_storageslist.htm)

## Description

Deletes a storage record by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `DELETE`
- **Route:** `/v1/directories/storages/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Storage code to delete |

## Successful response

- **Status:** `204 No Content`

No body is returned. The storage is removed from the system.
