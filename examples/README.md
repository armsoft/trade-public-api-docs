# Examples

🔗 [Online documentation](https://online.armsoft.am/trade7/restapi.htm)

Example requests are currently documented directly in endpoint pages and guides.

## Where to start

- [Getting Started Guide](../docs/getting-started.md)
- [Authentication Guide](../docs/authentication.md)
- [Products API Reference](../docs/api/directories/products/README.md)
- [List Products Example](../docs/api/directories/products/list.md)
- [List Partners Example](../docs/api/directories/partners/list.md)
- [Error Handling Guide](../docs/error-handling.md)

## C# Examples

Ready-to-use C# samples are available in the [`csharp/directories/`](csharp/directories/) folder:

- [`ProductsClient.cs`](csharp/directories/ProductsClient.cs) — wrapper for Products endpoints
- [`ProductMeasureUnitsClient.cs`](csharp/directories/ProductMeasureUnitsClient.cs) — wrapper for Measure Units 
- [`BarcodesClient.cs`](csharp/directories/BarcodesClient.cs) — wrapper for Barcodes endpoints
- [`CashDesksClient.cs`](csharp/directories/CashDesksClient.cs) — wrapper for Cash Desks endpoints
- [`PartnersClient.cs`](csharp/directories/PartnersClient.cs) — wrapper for Partners endpoints
- [`PartnersGroupsClient.cs`](csharp/directories/PartnersGroupsClient.cs) — wrapper for Partner Groups endpoints
- [`JournalsClient.cs`](csharp/directories/JournalsClient.cs) — wrapper for Journals endpoints
- [`ReportsClient.cs`](csharp/directories/ReportsClient.cs) — wrapper for Reports endpoints

Individual operation examples are in the per-directory subfolders (e.g. `csharp/directories/products/`,
`csharp/directories/measure-units/`, `csharp/directories/barcodes/`, etc.)

## Journals and Reports Examples

- [C# Journals examples](csharp/journals/README.md)
- [C# Reports examples](csharp/reports/README.md)

## Planned additions

- cURL collection for all endpoints
- Postman collection
