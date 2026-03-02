# Pagination

This document explains how to handle paginated responses from list endpoints.

## Overview

Many API list endpoints support pagination to retrieve large datasets in manageable chunks. Pagination is controlled using the `pageSize` parameter in the request body.

## Request Parameters

### pageSize

- **Type:** `integer`
- **Required:** No
- **Default:** 0 (returns all rows)
- **MinPageSize:** 5000 (if pageSize > 0 & pageSize < 5000 then 5000 rows will be returned)
- **Description:** The number of rows to return per request. If `pageSize` is not provided or set to `0`, all rows are returned in a single response.

## Response Properties

When pagination is used, each row in the response data includes pagination metadata:

### id

- **Type:** `string` (UUID)
- **Description:** Unique identifier for the pagination context. Used when making subsequent page requests.

### hasMore

- **Type:** `boolean`
- **Description:** Indicates whether more results are available. If `true`, you can fetch the next page by calling the `/nextpage` endpoint.

## Fetching Next Pages

When `hasMore` is `true`, you can retrieve the next batch of results by:

1. Appending `/nextpage` to the endpoint URL
2. Sending a `NextPageRequest` in the request body

### NextPageRequest Schema

```json
{
  "id": "string (UUID)",
  "close": "boolean"
}
```

#### Fields

- **id** (required): The pagination context identifier from the previous response
- **close** (optional): Set to `true` if you no longer need subsequent pages. The server will stop maintaining the pagination context.

## Example Workflow

### Request Page 1

```bash
POST /v1/directories/products/list
Content-Type: application/json

{
  "showMode": "3",
  "pageSize": 10
}
```

### Response Page 1

```json
{
    "id": "550e8400-e29b-41d4-a716-446655440001",
    "hasMore": true,
    "data": [
        {
            "id": 100001,
            "code": "PROD001",
            "name": "Product 1"
        }
    ]
}
```

### Request Page 2 (Next Page)

```bash
POST /v1/directories/products/list/nextpage
Content-Type: application/json

{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "close": false
}
```

### Response Page 2

```json
{
    "id": "550e8400-e29b-41d4-a716-446655440001",
    "hasMore": true,
    "data": [
        {
        "id": 100011,
        "code": "PROD011",
        "name": "Product 11"
        }
    ]
}
```

When `hasMore` is `false`, no more pages are available.

## Stopping Pagination

If you determine you no longer need remaining pages, send a request with `"close": true`:

```bash
POST /v1/directories/products/list/nextpage
Content-Type: application/json

{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "close": true
}
```

This signals the server to release the pagination context and stop maintaining state for this pagination session.

## Best Practicesgit status

- **Always check `hasMore`**: Before making a `/nextpage` request, verify that `hasMore` is `true`
- **Store the pagination ID**: Keep the `id` value from the response to use in subsequent requests
- **Use `close` when done**: If you stop paginating before reaching the end, send a request with `"close": true` to clean up server resources
- **Handle errors gracefully**: If a `/nextpage` request fails, you may need to restart pagination from the beginning
- **Use appropriate page sizes**: Balance between fewer large requests and more small requests based on your needs

## Supported Endpoints

Pagination is supported on these calls:

- `POST /v1/directories/products/list`
- `POST /v1/directories/products/measureunits/list`
- `POST /v1/directories/barcodes/list`
- `POST /v1/directories/partners/list`
- `POST /v1/directories/partners/contracts/list`
- `POST /v1/reports/journals/{journalName}`
- `POST /v1/reports/reports/{reportName}`
- Other directory and report list endpoints

Consult the specific endpoint documentation for details on available filters and response properties.
