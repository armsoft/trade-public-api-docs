# Products Measure Units

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_measureunits.htm)

## Description

CRUD operations for product measure units.

## Endpoints

- `POST /v1/directories/products/measureunits/list`
- `POST /v1/directories/products/measureunits/list/nextpage`
- `GET /v1/directories/products/{productCode}/measureunits/{unitCode}`
- `POST /v1/directories/products/measureunits`
- `PUT /v1/directories/products/{productCode}/measureunits/{unitCode}`
- `DELETE /v1/directories/products/{productCode}/measureunits/{unitCode}`

## Authorization

API key in header `apiKey`.

---

## Next page

Use the `id` token returned by `/list` to retrieve the next page of measure units.

- **Method:** `POST`
- **Route:** `/v1/directories/products/measureunits/list/nextpage`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

### Request body (example)

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "close": false
}
```

### Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the same paged format as `/list` with `id`, `hasMore`, and `data`.
