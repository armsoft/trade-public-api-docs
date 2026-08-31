# Cash Desks - Get

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_cashdesks.htm)

## Description

Retrieves cash desk information.  
- If **code is provided** → returns a single cash desk  
- If **code is not provided** → returns all cash desks  

---

## Endpoints

### 1. Get all cash desks

- **Method:** `GET`  
- **Route:** `/v1/directories/cashdesks`  
- **Authorization:** API key in header `apiKey`  

#### Query parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| showAlsoClosed | boolean | No | `true` | When `true`, closed cash desks (`isClosed: true`) are returned together with the open ones. Pass `false` to return only cash desks that are not closed. |

---

### 2. Get cash desk by code

- **Method:** `GET`  
- **Route:** `/v1/directories/cashdesks/{code}`  
- **Authorization:** API key in header `apiKey`  

---

## Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | No | Cash desk code |

---

## Successful responses

### When `code` is provided

- **Status:** `200 OK`  
- **Returns:** single `CashDesk` object  

```json
{
  "code": "CD001",
  "name": "Main Cash Desk",
  "nextSaleNumber": "1001",
  "default": true,
  "ecr": false,
  "cashLimit": "500000",
  "isClosed": false
}
```

### When `code` is not provided

- **Status:** `200 OK`  
- **Returns:** array of `CashDesk` objects  

```json
[
  {
    "code": "CD001",
    "name": "Main Cash Desk",
    "nextSaleNumber": "1001",
    "default": true,
    "ecr": false,
    "cashLimit": "500000",
    "isClosed": false
  },
  {
    "code": "CD002",
    "name": "Archived Desk",
    "nextSaleNumber": "2001",
    "default": false,
    "ecr": false,
    "cashLimit": "0",
    "isClosed": true
  }
]
```

---

## Response field notes

- `isClosed` – `true` when the cash desk is closed (no longer in active use). Closed cash desks
  are included in the list response unless `showAlsoClosed=false` is passed.

---

## Usage example

```bash
# only cash desks that are not closed
curl -X GET "https://api.armsoft.am/trade/v1/directories/cashdesks?showAlsoClosed=false" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY"
```
