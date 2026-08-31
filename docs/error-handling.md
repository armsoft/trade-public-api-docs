# Error Handling

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_errors.htm)

## Overview

The ArmSoft SME Trade Public API uses standard HTTP status codes and returns structured JSON error responses with localized messages.

## Error Response Format

All errors return a consistent JSON structure:

```json
{
  "message": "Detailed error description",
  "fieldName": "problematic-field-name",
  "errorCode": "SPECIFIC_ERROR_CODE"
}
```

### Properties

| Property | Type | Required | Description |
|----------|------|----------|-------------|
| `message` | string | Yes | Human-readable error description (localized) |
| `fieldName` | string | No | Name of the field that caused the error |
| `errorCode` | string | No | Machine-readable error code |

## HTTP Status Codes

### 2xx Success

| Code | Description | When It Occurs |
|------|-------------|----------------|
| `200` | OK | Successful GET, PUT, DELETE operation |
| `201` | Created | Resource created successfully (POST) |

### 4xx Client Errors

| Code | Description | Common Causes |
|------|-------------|---------------|
| `400` | Bad Request | Invalid JSON syntax, missing required fields, validation errors |
| `401` | Unauthorized | Missing API key, invalid API key |
| `403` | Forbidden | Public API not enabled for the key, or the key has limited access |
| `404` | Not Found | Product/resource doesn't exist |
| `405` | Method Not Allowed | HTTP method is not supported for endpoint |
| `409` | Conflict | Duplicate code, resource in use (cannot delete) |
| `429` | Too Many Requests | Rate limit exceeded |

### 5xx Server Errors

| Code | Description | Action Required |
|------|-------------|-----------------|
| `500` | Internal Server Error | Contact support with error details |
| `503` | Service Unavailable | Retry later; service temporarily unavailable |

## Common Errors

### 1. Authentication Errors

#### Missing API Key

**Request:**

```bash
curl -X GET "https://api.armsoft.am/trade/v1/directories/products/PROD001"
```

**Response:**

```json
HTTP/1.1 401 Unauthorized
{ "message": "Missing API Key" }
```

**Solution:** Include `apiKey` header in all requests

```bash
curl -X GET "https://api.armsoft.am/trade/v1/directories/products/PROD001" \
  -H "apiKey: your-api-key-here"
```

---

#### API Key Without Public API Access

**Request:**

```bash
curl -X GET "https://api.armsoft.am/trade/v1/directories/products/PROD001" \
  -H "apiKey: not-enabled-key-12345"
```

**Response:**

```json
HTTP/1.1 403 Forbidden
{ "message": "Public API access is not available for this API Key" }
```

**Solution:** 
- Verify API key is correct
- Check that Public API access is enabled for the key
- Contact administrator if issue persists

---

#### Access Denied (Limited Access Key)

**Request:**

```bash
curl -X DELETE "https://api.armsoft.am/trade/v1/directories/products/PROD001" \
  -H "apiKey: limited-access-key"
```

**Response:**

```json
HTTP/1.1 403 Forbidden
{ "message": "Access denied. This API Key has limited access and cannot perform this operation." }
```

**Solution:**
- Use full-access API key for administrative operations
- Or restrict your application to limited-access endpoints
- Contact administrator to upgrade access level

---

### 2. Validation Errors

#### Missing Required Field

**Request:**

```bash
curl -X POST "https://api.armsoft.am/trade/v1/directories/products/list" \
  -H "apiKey: your-api-key-here" \
  -H "Content-Type: application/json" \
  -d '{}'
```

**Response:**

```json
HTTP/1.1 400 Bad Request
{ "message": "ShowMode is required", "fieldName": "showMode" }
```

**Solution:** Include all required fields

```json
{ "showMode": "3" }
```

---

### 3. Resource Errors

#### Resource Not Found

**Request:**

```bash
curl -X GET "https://api.armsoft.am/trade/v1/directories/products/INVALID001" \
  -H "apiKey: your-api-key-here"
```

**Response:**

```
HTTP/1.1 404 Not Found
```
