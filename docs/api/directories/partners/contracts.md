# Partners - Contracts
🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_partners.htm)

## Description

Endpoints for managing contracts attached to partners.

---

### List contracts

Returns a list of partner contracts using filters.

- **Method:** `POST`
- **Route:** `/v1/directories/partners/contracts/list`
- **Request body:** `ContractFilters` object

Example request body:

```json
{
  "partnerCode": "P001",
  "pageSize": 5000
}
```

Successful response returns a `ContractRowApiResponse` object with paging metadata.

Pagination is supported via `pageSize`; see [Pagination](../../../pagination.md).

---

### Next page

Use the `id` token returned by `/list` to retrieve the next page of contracts.

- **Method:** `POST`
- **Route:** `/v1/directories/partners/contracts/list/nextpage`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

#### Request body (example)

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "close": false
}
```

#### Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the same `ContractRowApiResponse` format as `/list`.

---

### Get single contract

- **Method:** `GET`
- **Route:** `/v1/directories/partners/{partnerCode}/contracts/{contractCode}`

Returns the specified `Contract` object.

Path parameters:

| Name | Type | Required | Description |
|------|------|----------|-------------|
| partnerCode | string | Yes | Partner code |
| contractCode | string | Yes | Contract code |

---

### Create contract

- **Method:** `POST`
- **Route:** `/v1/directories/partners/contracts`
- **Request body:** `Contract` object

Returns the created `Contract`.

---

### Update contract

- **Method:** `PUT`
- **Route:** `/v1/directories/partners/{partnerCode}/contracts/{contractCode}`
- **Request body:** `Contract` object

Replaces all fields of an existing contract and returns the updated record.

---

### Delete contract

- **Method:** `DELETE`
- **Route:** `/v1/directories/partners/{partnerCode}/contracts/{contractCode}`

Removes the specified contract.

Successful response is `200 OK` with an empty body.
