using System.Net;

// DELETE /directories/products/{code}
// Deletes a product permanently. Returns 200 on success.

var baseUrl     = "https://api.armsoft.am/trade/v1";
var apiKey      = "{your-api-key}";
var productCode = "1001";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var response = await client.DeleteAsync(
    $"/directories/products/{Uri.EscapeDataString(productCode)}");

switch (response.StatusCode)
{
    case HttpStatusCode.OK:
        Console.WriteLine($"Product '{productCode}' deleted successfully.");
        break;
    case HttpStatusCode.NotFound:
        Console.WriteLine($"Product '{productCode}' not found.");
        break;
    case HttpStatusCode.Conflict:
        Console.WriteLine("Cannot delete: product is referenced by other records.");
        break;
    default:
        response.EnsureSuccessStatusCode();
        break;
}
