# Version

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi_version.htm)

Retrieves the current API version string.

## Endpoint

- **Base URL:** `https://api.armsoft.am/trade`
- **Method:** `GET`
- **Route:** `/api/Version`
- **Authorization:** None

## Successful response

- **Status:** `200 OK`
- **Content types:** `text/plain`, `application/json`, `text/json`

Returns a plain string containing the API version.

### Example response

```json
"1.0"
```

### Example request

```bash
curl -X GET "https://api.armsoft.am/trade/api/Version"
```
