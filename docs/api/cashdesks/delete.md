# Cash Desks - Delete

## Description

Deletes a cash desk record by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `DELETE`
- **Route:** `/v1/directories/cashdesks/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Cash desk code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json` (empty body)

The record is removed; no response content is returned.
