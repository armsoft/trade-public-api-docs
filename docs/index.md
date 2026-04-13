# ArmSoft Trade Public API

[![API Version](https://img.shields.io/badge/version-1.0-blue.svg)](https://github.com/armsoft/trade-public-api-docs)
[![OpenAPI](https://img.shields.io/badge/OpenAPI-3.0-green.svg)](https://github.com/armsoft/trade-public-api-docs/blob/main/openapi/openapi.yaml)

Official documentation for the **ArmSoft Trade Public API** — programmatic access to ArmSoft SME Trade data including products, partners, documents, journals, and reports.

## Quick Navigation

| Where to go | Description |
|---|---|
| [Getting Started](getting-started.md) | Set up your API key and make your first request |
| [Authentication](authentication.md) | API key types, headers, and access levels |
| [Error Handling](errors.md) | HTTP status codes and error response format |
| [Pagination](pagination.md) | Paginating large list responses |
| [Localization](localization.md) | Multi-language request headers |
| [API Reference](api/README.md) | All endpoints — directories, documents, journals, reports |
| [Live API Reference](api/swagger.md) | Interactive Redoc view of the OpenAPI spec |
| [Examples](examples.md) | Ready-to-use C# code samples |

## What You Can Do

| Category | Operations |
|---|---|
| **Directories** | Manage products, partners, barcodes, cash desks, storages, price list types |
| **Documents** | Create and retrieve sales, invoices, transfer invoices, storage orders |
| **Journals** | Query all-documents journal and ECR checks |
| **Reports** | Products balances, partners balances, price lists, sales analysis, bonus balances |

## Base URL

```
https://api.armsoft.am/trade/v1
```

## Authentication

Every request requires an `apiKey` header:

```http
GET /v1/directories/products/PROD001
apiKey: your-api-key-here
Accept-Language: en-US
```

## Multi-Language Support

| Header value | Language |
|---|---|
| `hy-AM` | Armenian (default) |
| `en-US` | English |
| `ru-RU` | Russian |

## OpenAPI Specification

The authoritative API contract is maintained at [`openapi/openapi.yaml`](https://github.com/armsoft/trade-public-api-docs/blob/main/openapi/openapi.yaml)
and [`swagger.json`](https://github.com/armsoft/trade-public-api-docs/blob/main/swagger.json).
Use the [Live API Reference](api/swagger.md) for an interactive view.
