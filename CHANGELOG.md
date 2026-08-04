# Changelog

All notable changes to the ArmSoft SME Trade Public API are documented here.

## [Unreleased] - 2026-07-31

### Added

#### Closed records support
- `isClosed` flag added to the `CashDesk`, `Storage`, `Partner` and `PartnerRow` schemas –
  marks a directory record that is closed and no longer in active use.
- `GET /directories/cashdesks` – new optional `showAlsoClosed` query parameter
  (default `true`; pass `false` to return only cash desks that are not closed).
- `GET /directories/storages` – new optional `showAlsoClosed` query parameter
  (default `true`; pass `false` to return only storages that are not closed).
- `POST /directories/partners/list` – new optional `showAlsoClosed` filter in `PartnerFilters`
  (omitted or `false` returns only partners that are not closed).

### Changed
- Russian field labels corrected for `PartnerRow.userName` (`Создатель`),
  `ProductRow.creatorName` (`Создатель`) and `ProductRow.lastModifierName` (`Последний редактор`).
- `GET /api/Version` is documented as not requiring the `apiKey` header, matching the served spec.

## [1.0.0] - 2026-02-20

### Added

#### Products API
- Complete CRUD operations for products
  - List products with filters (showMode, group, type, codes, pricing)
  - Get product details including measure units and barcodes
  - Create products with auto code generation
  - Update product properties
  - Delete products
- Product Measure Units management
  - List measure units for products
  - Create alternative units (PCS, BOX, CARTON, etc.)
  - Set conversion coefficients
  - Mark default units
  - Update measure unit properties
  - Delete measure units

#### Documentation
- Comprehensive endpoint documentation with examples
- Getting started guide
- Authentication guide
- Error handling guide
- Data schema definitions
- Troubleshooting and FAQ

#### Code Examples
- C# HTTP client library
- 10+ C# usage examples
- 11+ cURL examples
- Postman collection

#### Specifications
- OpenAPI 3.0 specification
- Complete API reference
- Data model schemas

### Status Codes
- `200 OK` - Successful request
- `201 Created` - Resource created
- `400 Bad Request` - Invalid parameters
- `401 Unauthorized` - Missing API key
- `404 Not Found` - Resource not found
- `409 Conflict` - Resource conflict
- `500 Server Error` - Internal error

### Security
- HTTPS/TLS required for all requests
- API key authentication via `apiKey` header
- API key management via administrative interface
- No sensitive data in logs

---

## Support

For questions or issues:
- Review [documentation](docs/)
- Check [troubleshooting guide](docs/troubleshooting/)
- Contact support@armsoft.am