# Partners Groups - Get

## Description

Retrieves partner group information.  
- If **code is provided** → returns a single partner group  
- If **code is not provided** → returns all partner groups  

---

## Endpoints

### 1. Get all partner groups

- **Method:** `GET`  
- **Route:** `/v1/directories/partnersgroups`  
- **Authorization:** API key in header `apiKey`  

---

### 2. Get partner group by code

- **Method:** `GET`  
- **Route:** `/v1/directories/partnersgroups/{code}`  
- **Authorization:** API key in header `apiKey`  

---

## Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | No | Partner group code |

---

## Successful responses

### When `code` is provided

- **Status:** `200 OK`  
- **Returns:** single `PartnersGroup` object  

```json
{
  "code": "PG001",
  "name": "Wholesale",
  "parent": "",
  "path": "PG001"
}