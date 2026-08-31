# Localization

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi.htm)

The API supports three locales for human-readable display fields (e.g. `typeName`, `groupName`, `countryName`).

## Accept-Language Header

Pass the desired locale in the `Accept-Language` request header:

| Value | Language |
|-------|----------|
| `hy-AM` | Armenian (default) |
| `en-US` | English |
| `ru-RU` | Russian |

**Example:**

```http
POST /directories/products/list
Accept-Language: en-US
apiKey: {your-api-key}
```

When `Accept-Language` is omitted, the API defaults to `hy-AM`.

> **Note:** Localised fields are display strings only. All code and identifier fields are locale-independent.
