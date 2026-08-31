# ArmSoft Trade Public API Documentation

[![API Version](https://img.shields.io/badge/version-1.0-blue.svg)](https://github.com/armsoft/trade-public-api-docs)
[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4)](https://dotnet.microsoft.com/)
[![OpenAPI](https://img.shields.io/badge/OpenAPI-3.0-green.svg)](./openapi/openapi.yaml)
[![Sync Swagger](https://github.com/armsoft/trade-public-api-docs/actions/workflows/sync-swagger.yml/badge.svg)](https://github.com/armsoft/trade-public-api-docs/actions/workflows/sync-swagger.yml)

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi.htm)

Official documentation for the ArmSoft Trade Public API.

## 📋 Overview

The ArmSoft Trade Public API provides programmatic access to:

- **Products**: Product catalog management with CRUD operations
- **Product Measure Units**: Alternative measurement units management
- **Multi-language Support**: Armenian (hy-AM), English (en-US), Russian (ru-RU)

### Key Features

✅ RESTful design with JSON responses  
✅ API Key authentication (header-based)  
✅ Comprehensive error handling  
✅ OpenAPI/Swagger specification  
✅ Multi-language support  
✅ Built on ASP.NET Core 10 / C# 13  

## 🚀 Quick Start

### 1. Get Your API Key

Contact your ArmSoft administrator to obtain an API key.

### 2. Make Your First Request

```bash
curl -X GET "https://api.armsoft.am/trade/v1/directories/products/PROD001" \
  -H "apiKey: your-api-key-here" \
  -H "Accept-Language: hy-AM"
```

### 3. Response

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

## 🔐 Authentication

All API requests require an API key in the request header:

```http
apiKey: your-api-key-here
Accept-Language: hy-AM
```

**API Key Types:**
- **Full Access**: Complete CRUD operations on all resources
- **Limited Access**: Restricted to specific operations (e.g., online store)

📖 **[Full Authentication Guide](docs/authentication.md)**

## 📚 API Reference

### Base URL
https://api.armsoft.am/trade/v{version}

Current version: **v1**

### Products Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/directories/products/list` | Get all products with filters |
| GET | `/directories/products/{code}` | Get product by code |
| POST | `/directories/products` | Create new product |
| PUT | `/directories/products/{code}` | Update product |
| DELETE | `/directories/products/{code}` | Delete product |

### Product Groups Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/directories/productsgroups` | Get all product groups |
| GET | `/directories/productsgroups/{code}` | Get product group by code |
| POST | `/directories/productsgroups` | Create new product group |
| PUT | `/directories/productsgroups/{code}` | Update product group |
| DELETE | `/directories/productsgroups/{code}` | Delete product group |

### Product Measure Units Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/directories/products/measureunits/list` | Get all measure units |
| GET | `/directories/products/{productCode}/measureunits/{unitCode}` | Get measure unit |
| POST | `/directories/products/measureunits` | Create measure unit |
| PUT | `/directories/products/{productCode}/measureunits/{unitCode}` | Update measure unit |
| DELETE | `/directories/products/{productCode}/measureunits/{unitCode}` | Delete measure unit |

### Barcodes Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/directories/barcodes/list` | Get all barcodes with filters |
| POST | `/directories/barcodes/nextpage` | Get next page of barcodes |
| GET | `/directories/barcodes/{code}` | Get barcode by code |
| POST | `/directories/barcodes` | Create new barcode |
| PUT | `/directories/barcodes/{code}` | Update barcode |
| DELETE | `/directories/barcodes/{code}` | Delete barcode |

### Cash Desks Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/directories/cashdesks` | List all cash desks (optional `?showAlsoClosed=false` hides closed ones) |
| GET | `/directories/cashdesks/{code}` | Get cash desk by code |
| POST | `/directories/cashdesks` | Create new cash desk |
| PUT | `/directories/cashdesks/{code}` | Update cash desk |
| DELETE | `/directories/cashdesks/{code}` | Delete cash desk |

### Partners Groups Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/directories/partnersgroups` | Get all partners groups |
| GET | `/directories/partnersgroups/{code}` | Get partner group by code |
| POST | `/directories/partnersgroups` | Create new partner group |
| PUT | `/directories/partnersgroups/{code}` | Update partner group |
| DELETE | `/directories/partnersgroups/{code}` | Delete partner group |

### Partners Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/directories/partners/list` | Get all partners with filters |
| GET | `/directories/partners/{code}` | Get partner by code |
| POST | `/directories/partners` | Create new partner |
| PUT | `/directories/partners/{code}` | Update partner |
| DELETE | `/directories/partners/{code}` | Delete partner |
| POST | `/directories/partners/contracts/list` | Get partner contracts |
| POST | `/directories/partners/contracts` | Create new contract |
| GET | `/directories/partners/{partnerCode}/contracts/{contractCode}` | Get contract |
| PUT | `/directories/partners/{partnerCode}/contracts/{contractCode}` | Update contract |
| DELETE | `/directories/partners/{partnerCode}/contracts/{contractCode}` | Delete contract |

### Price List Types Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/directories/pricelisttypes` | List all price list types |
| GET | `/directories/pricelisttypes/{code}` | Get price list type by code |
| POST | `/directories/pricelisttypes` | Create new price list type |
| PUT | `/directories/pricelisttypes/{code}` | Update price list type |
| DELETE | `/directories/pricelisttypes/{code}` | Delete price list type |

### Storages Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/directories/storages` | Get all storages (optional `?showAlsoClosed=false` hides closed ones) |
| GET | `/directories/storages/{code}` | Get storage by code |
| POST | `/directories/storages` | Create new storage |
| PUT | `/directories/storages/{code}` | Update storage |
| DELETE | `/directories/storages/{code}` | Delete storage |

### Journals Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/journals/alldocuments` | Get all documents journal rows |
| POST | `/journals/alldocuments/nextpage` | Next page for documents journal |
| POST | `/journals/ecrchecks` | Get ECR checks journal rows |
| POST | `/journals/ecrchecks/nextpage` | Next page for ECR checks journal |

### Reports Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/reports/partnersbalances` | Partner balances report |
| POST | `/reports/partnersbalances/nextpage` | Partner balances next page |
| POST | `/reports/productsbalances` | Product balances report |
| POST | `/reports/productsbalances/nextpage` | Product balances next page |
| POST | `/reports/productsbalances/short` | Products balances short report |
| POST | `/reports/productsbalances/short/nextpage` | Products balances short next page |
| POST | `/reports/pricelist` | Price list report |
| POST | `/reports/pricelist/nextpage` | Price list next page |
| POST | `/reports/salesanalysis` | Sales analysis report |
| POST | `/reports/salesanalysis/nextpage` | Sales analysis next page |
| POST | `/reports/bonusbalances` | Bonus balances report |
| POST | `/reports/bonusbalances/nextpage` | Bonus balances next page |

📖 **[Code Examples](examples/README.md)**

## 📖 Documentation

| Document | Description |
|----------|-------------|
| [Getting Started](docs/getting-started.md) | Installation and setup guide |
| [Authentication](docs/authentication.md) | API key authentication details |
| [API Reference](docs/api/README.md) | Complete endpoint documentation |
| [Products API](docs/api/directories/products/README.md) | Detailed Products endpoint reference |
| [Measure Units API](docs/api/directories/products/measure-units.md) | Measure Units endpoint reference |
| [Pagination](docs/pagination.md) | Pagination and filtering guide |
| [Localization](docs/localization.md) | Multi-language support details |
| [Error Handling](docs/error-handling.md) | Error codes and responses |
| [Changelog](CHANGELOG.md) | Version history and changes |

## 🛠️ OpenAPI Specification

Interactive API documentation available via Swagger:

- **Swagger UI**: `https://api.armsoft.am/trade/swagger`
- **OpenAPI Spec**: [openapi/openapi.yaml](openapi/openapi.yaml)

Import the OpenAPI specification into:
- Postman
- SwaggerHub
- Any OpenAPI-compatible tool

## 🤖 Auto-Generated Documentation

This repository maintains automatically synchronized API documentation:

- **`swagger.json`** — Live OpenAPI specification fetched from `https://api.armsoft.am/trade/swagger/v1/swagger.json`
- **`docs/api-reference.md`** — Auto-generated Markdown reference documentation

### How it works

A GitHub Actions workflow ([`.github/workflows/sync-swagger.yml`](.github/workflows/sync-swagger.yml)) runs every hour to:

1. Fetch the latest `swagger.json` from the live API
2. Compare it with the committed version
3. If changes are detected:
   - Update `swagger.json`
   - Regenerate `docs/api-reference.md` using [widdershins](https://github.com/Mermade/widdershins)
   - Commit and push the changes automatically

### Manual sync

To manually trigger a documentation sync:

1. Go to the [Actions tab](https://github.com/armsoft/trade-public-api-docs/actions/workflows/sync-swagger.yml)
2. Click "Run workflow" → "Run workflow"

The workflow runs in ~30 seconds and updates the docs if changes are detected.

**Note:** If the API endpoint ever requires authentication, add an `API_TOKEN` secret to the repository settings. The workflow includes commented placeholders for this.

## 🌍 Multi-Language Support

Set the `Accept-Language` header to receive localized responses:

| Language | Code | Example |
|----------|------|---------|
| Armenian | `hy-AM` | `Accept-Language: hy-AM` |
| English | `en-US` | `Accept-Language: en-US` |
| Russian | `ru-RU` | `Accept-Language: ru-RU` |

## 📊 HTTP Status Codes

| Code | Description |
|------|-------------|
| 200 | OK - Successful request |
| 201 | Created - Resource created successfully |
| 400 | Bad Request - Invalid request data |
| 401 | Unauthorized - Missing or invalid API key |
| 403 | Forbidden - Public API disabled for the key, or insufficient permissions |
| 404 | Not Found - Resource doesn't exist |
| 405 | Method Not Allowed |
| 409 | Conflict - Resource conflict (e.g., duplicate) |
| 429 | Too Many Requests - Rate limit exceeded |
| 500 | Internal Server Error |
| 503 | Service Unavailable |

## 🔄 Versioning

API version is specified in the URL:

```
/trade/v1/directories/products
```

- Current version: **v1**
- Backward compatibility maintained within major versions

## 📜 License

© 2026 ArmSoft - Armenian Software. All rights reserved.

This documentation is provided for API integration purposes. For licensing of the ArmSoft Trade system, contact ArmSoft.

## 🏢 About ArmSoft

ArmSoft is a leading provider of enterprise resource planning (ERP) solutions for businesses in Armenia and beyond. The Trade system is designed for small and medium enterprises to manage their trade operations efficiently.

---

## 🤖 AI & LLM Usage

This repository includes machine-readable index files for AI tools and web crawlers:

- [llms.txt](llms.txt) — structured index of all docs and endpoints
- [llms-full.txt](llms-full.txt) — full inline content for AI tools that don't follow links
