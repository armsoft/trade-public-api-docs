# Product Groups - Get

## Description

Retrieves product group information.  
- If **code is provided** → returns a single product group  
- If **code is not provided** → returns all product groups  

---

## Endpoints

### 1. Get all product groups

- **Method:** `GET`  
- **Route:** `/v1/directories/productsgroups`  
- **Authorization:** API key in header `apiKey`  

---

### 2. Get product group by code

- **Method:** `GET`  
- **Route:** `/v1/directories/productsgroups/{code}`  
- **Authorization:** API key in header `apiKey`  

---

## Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | No | Product group code |

---

## Successful responses

### When `code` is provided

- **Status:** `200 OK`  
- **Returns:** single `ProductsGroup` object  

```json
{
  "code": "PG110",
  "name": "Televisions",
  "parent": "PG100",
  "path": "PG100!PG110"
}