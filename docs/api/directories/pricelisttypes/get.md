# Price List Types - Get

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_pricelisttypes.htm)

## Description

Retrieves price list type information.  
- If **code is provided** → returns a single price list type  
- If **code is not provided** → returns all price list types  

---

## Endpoints

### 1. Get all price list types

- **Method:** `GET`  
- **Route:** `/v1/directories/pricelisttypes`  
- **Authorization:** API key in header `apiKey`  

---

### 2. Get price list type by code

- **Method:** `GET`  
- **Route:** `/v1/directories/pricelisttypes/{code}`  
- **Authorization:** API key in header `apiKey`  

---

## Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | No | Price list type code |

---

## Successful responses

### When `code` is provided

- **Status:** `200 OK`  
- **Returns:** single `PriceListType` object  

```json
{
  "code": "01",
  "name": "Retail",
  "currency": "AMD",
  "roundingDegree": "0.01",
  "includingVAT": true
}
