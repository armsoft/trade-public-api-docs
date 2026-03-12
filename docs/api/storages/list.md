# Storages - List

## Description

Returns a list of all storages, with optional limit and pagination support.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/storages`
- **Authorization:** API key in header `apiKey`

### Query parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| limit | integer | No | Maximum number of items to return (default 100) |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns an array of `Storage` objects.

### Example

```json
[{"code":"ST001","name":"Main Warehouse","address":"1000 Market St","phone":"555-0100"}]
```

## Pagination

If there are more results than the `limit`, the server will return a `NextPageRequest` object containing info to request the next set of results.

### Next page request example

```json
{
  "url": "https://api.armsoft.am/trade/v1/directories/storages/nextpage",
  "body": { "limit": 100, "offset": 100 }
}
```
