# Cash Desks - Get

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
  "cashLimit": "500000"
}