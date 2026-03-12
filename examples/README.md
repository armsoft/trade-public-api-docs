# Examples

Example requests are currently documented directly in endpoint pages and guides.

## Where to start

- [Getting Started Guide](../docs/getting-started.md)
- [Authentication Guide](../docs/authentication.md)
- [Products API Reference](../docs/api/products/README.md)
- [List Products Example](../docs/api/products/list.md)
- [List Partners Example](../docs/api/partners/list.md)
- [Error Handling Guide](../docs/error-handling.md)

## C# Examples

Ready-to-use C# samples are available in the [`csharp/`](csharp/) folder:

- [`ProductsClient.cs`](csharp/ProductsClient.cs) — wrapper for Products endpoints
- [`ProductMeasureUnitsClient.cs`](csharp/ProductMeasureUnitsClient.cs) — wrapper for Measure Units 
- [`BarcodesClient.cs`](csharp/BarcodesClient.cs) — wrapper for Barcodes endpoints
- [`CashDesksClient.cs`](csharp/CashDesksClient.cs) — wrapper for Cash Desks endpoints
- [`PartnersClient.cs`](csharp/PartnersClient.cs) — wrapper for Partners endpoints
- [`PartnersGroupsClient.cs`](csharp/PartnersGroupsClient.cs) — wrapper for Partner Groups endpointsendpoints

Individual operation examples are in the per-directory subfolders (e.g. `csharp/products/`,
`csharp/measure-units/`, `csharp/barcodes/`, etc.)

## Planned additions

- cURL collection for all endpoints
- Postman collection