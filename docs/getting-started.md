# Getting Started with ArmSoft SME Trade Public API

This guide will help you make your first API call in under 5 minutes.

## Prerequisites

- **API Key**: Obtain from your ArmSoft administrator
- **Base URL**: Your ArmSoft API endpoint (e.g., `https://api.armsoft.am/trade/v1`)
- **.NET SDK**: .NET 10.0 or later (for C# examples)

## Quick Start

### Step 1: Verify Your API Key

Test your API key with a simple request:

```bash
curl -X POST "https://api.armsoft.am/trade/v1/directories/products/list" \
  -H "apiKey: your-api-key-here" \
  -H "Accept-Language: en-US" \
  -H "Content-Type: application/json" \
  -d '{"showMode": "3"}'
```

**Expected Response:**

```json
{
    "id": 12345,
    "code": "PROD001",
    "name": "Sample Product",
    "baseUnitMeasure": "PCS",
    "vat": true,
    "showInPriceLists": true
}
```

## Next Steps

- Read the endpoint docs: [Products API](api/products/README.md)
- Import the OpenAPI file into Postman/Insomnia: [openapi/openapi.yaml](../openapi/openapi.yaml)