## 🔐 Authentication & Authorization
 
All API endpoints require authorization using an API Key. Clients must include a valid `apiKey` in the request header for every request.
 
---
 
### Authentication Method
 
**Header Name:**  
`apiKey`
 
**Header Value:**  
`Your generated API key`

### cURL Authentication Example

```bash
curl -X GET \
    "https://api.armsoft.am/trade/v1/directories/cashdesks" \
    -H "accept: text/plain" \
    -H "Accept-Language: hy-AM" \
    -H "apiKey: YOUR_API_KEY"
```

Use your real API key in the `apiKey` header.
 
---
 
## API Key Types

### 1. Full Access

**Capabilities:**
- ✅ Complete CRUD operations on all resources
- ✅ Access to all directories (Products, Partners, etc.)
- ✅ Document creation and management
- ✅ Administrative operations
- ✅ All API endpoints available

**Use Cases:**
- Internal integrations
- ERP system connections
- Full-featured third-party applications
- Administrative tasks

### 2. Limited Access (Online Store)

**Capabilities:**
- ✅ Read-only access to product catalog
- ✅ Read-only access to partners
- ✅ Create sale documents
- ✅ View price lists and balances
- ❌ No product modification
- ❌ No partner modification
- ❌ No administrative functions
- ❌ No document deletion

**Use Cases:**
- E-commerce integrations
- Public-facing product catalogs
- Mobile apps for customers
- Point-of-sale systems
- Online stores

### Restricted API Keys (Online Store Access)

API keys with restricted permissions are limited to the following endpoints:

#### Directories (Read Only)

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/directories/products/list` | Get all products |
| GET | `/directories/products/{code}` | Get product by code |
| POST | `/directories/products/measureunits/list` | Get all measure units |
| GET | `/directories/products/{productCode}/measureunits/{unitCode}` | Get measure unit |

#### Reports

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/reports/price-list` | Get price list report |
| POST | `/reports/products/balances` | Get products balances |
| POST | `/reports/products/balances/short` | Get short balances |

#### Documents (Limited)

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/documents/sale/create` | Create sale document (MT bill) |
| GET | `/documents/sale/{isn}` | Get sale document by ISN |
| PUT | `/documents/sale/{isn}` | Update sale document |
| DELETE | `/documents/sale/{isn}` | Delete sale document |

#### Journal

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/journal/ecrchecks` | Get ECR check documents journal |

## How Authentication Works

Every request is validated server-side before processing:
1. The server reads the `apiKey` header value.
2. The key is looked up in the system and its access level is checked.
3. If the key is missing or invalid, a `401 Unauthorized` response is returned immediately.
4. If the key exists but lacks permission for the requested operation, a `401` with an access-denied message is returned.
5. On success, the request proceeds and the response is localized according to the `Accept-Language` header.

## Response Codes & Errors

### Authentication Errors

| Status Code | Description | Error Response |
|------------|-------------|----------------|
| `401 Unauthorized` | API key is missing | *(No response body)* |
| `401 Unauthorized` | API key is invalid | `{ "message": "Public API access is not available for this API Key" }` |
| `401 Unauthorized` | Insufficient permissions | `{ "message": "Access denied. This API Key has limited access and cannot perform this operation." }` |

### Error Examples

#### Missing API Key
**Request:**

```bash
curl -X GET "https://api.armsoft.am/trade/v1/directories/products/PROD001"
```

**Response:**

```
HTTP/1.1 401 Unauthorized (No response body)
```

#### Invalid API Key
**Request:**

```bash
curl -X GET "https://api.armsoft.am/trade/v1/directories/products/PROD001" \
  -H "apiKey: invalid-key-12345"
```

**Response:**

```json
HTTP/1.1 401 Unauthorized
{ "message": "Public API access is not available for this API Key" }
```

#### Access Denied (Limited Access Key)
**Request:**

```bash
curl -X DELETE "https://api.armsoft.am/trade/v1/directories/products/PROD001" \
  -H "apiKey: limited-access-key"
```

**Response:**

```json
HTTP/1.1 401 Unauthorized
{ "message": "Access denied. This API Key has limited access and cannot perform this operation." }
```

## Multi-Language Support

### Setting Language
Use the `Accept-Language` header:

```http
Accept-Language: hy-AM  # Armenian (default)
Accept-Language: en-US  # English
Accept-Language: ru-RU  # Russian
```

### Language Impact

The language setting affects:
- ✅ Error messages
- ✅ Validation messages
- ✅ Localized field names

### Example: Armenian Response

```bash
curl -X GET "https://api.armsoft.am/trade/v1/directories/products/INVALID" \
  -H "apiKey: your-api-key-here" \
  -H "Accept-Language: hy-AM"
```

**Response:**

```json
{ "message": "Ապրանքը չի գտնվել" }
```

### Example: English Response

```bash
curl -X GET "https://api.armsoft.am/trade/v1/directories/products/INVALID" \
  -H "apiKey: your-api-key-here" \
  -H "Accept-Language: en-US"
```

**Response:**

```json
{ "message": "Product not found" }
```

## Obtaining an API Key

### Contact Administrator

Contact your ArmSoft system administrator or account manager to request an API key.

### Specify Access Level

Determine which type of API key you need:
- **Full Access**: For internal systems and trusted integrations
- **Limited Access**: For customer-facing applications and online stores

### Receive Credentials

You will receive:
- API Key (string format)
- API Base URL
- Documentation link
- Access level details

## Implementation Examples

### C# (.NET)

#### Basic HTTP Client Setup

```csharp
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class ArmsoftApiClient
{
    private readonly HttpClient _httpClient;
    private const string BaseUrl = "https://api.armsoft.am/trade/v1";

    public ArmsoftApiClient(string apiKey, string language = "en-US")
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(BaseUrl)
        };

        // Add authentication and language headers
        _httpClient.DefaultRequestHeaders.Add("apiKey", apiKey);
        _httpClient.DefaultRequestHeaders.Add("Accept-Language", language);
    }

    public async Task<T> GetAsync<T>(string endpoint)
    {
        var response = await _httpClient.GetAsync(endpoint);

        if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
        {
            throw new UnauthorizedAccessException("Invalid API key or insufficient permissions");
        }

        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<T>();
    }
}
```

#### Usage Example

```csharp
// Get API key from environment variable
var apiKey = Environment.GetEnvironmentVariable("ARMSOFT_API_KEY");
var client = new ArmsoftApiClient(apiKey, "en-US");

try
{
    var product = await client.GetAsync<Product>("directories/products/1001");
    Console.WriteLine($"Product: {product.Name}");
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine($"Authentication Error: {ex.Message}");
}
catch (HttpRequestException ex)
{
    Console.WriteLine($"API Error: {ex.Message}");
}
```