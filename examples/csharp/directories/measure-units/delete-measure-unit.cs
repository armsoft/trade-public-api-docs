using System.Net;

// DELETE /directories/products/{productCode}/measureunits/{unitCode}
// Deletes a measure unit from a product.

var baseUrl     = "https://api.armsoft.am/trade/v1";
var apiKey      = "{your-api-key}";
var productCode = "1001";
var unitCode    = "002";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var response = await client.DeleteAsync(
    $"/directories/products/{Uri.EscapeDataString(productCode)}" +
    $"/measureunits/{Uri.EscapeDataString(unitCode)}");

switch (response.StatusCode)
{
    case HttpStatusCode.OK:
        Console.WriteLine($"Measure unit '{unitCode}' deleted from product '{productCode}'.");
        break;
    case HttpStatusCode.NotFound:
        Console.WriteLine($"Measure unit '{unitCode}' not found for product '{productCode}'.");
        break;
    case HttpStatusCode.Conflict:
        Console.WriteLine("Cannot delete: measure unit is in use by other records.");
        break;
    default:
        response.EnsureSuccessStatusCode();
        break;
}
