using System.Net.Http.Json;
using System.Text.Json;

// GET /directories/products/{productCode}/measureunits/{unitCode}
// Returns a single measurement unit for a product.

var baseUrl     = "https://api.armsoft.am/trade/v1";
var apiKey      = "{your-api-key}";
var productCode = "1001";
var unitCode    = "002";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var response = await client.GetAsync(
    $"/directories/products/{Uri.EscapeDataString(productCode)}" +
    $"/measureunits/{Uri.EscapeDataString(unitCode)}");

if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
{
    Console.WriteLine($"Measure unit '{unitCode}' not found for product '{productCode}'.");
    return;
}

response.EnsureSuccessStatusCode();

var unit = await response.Content.ReadFromJsonAsync<JsonElement>();
Console.WriteLine($"Unit measure:    {unit.GetProperty("unitMeasure").GetString()}");
Console.WriteLine($"Abbreviation:    {unit.GetProperty("unitMeasureAbbreviation").GetString()}");
Console.WriteLine($"Coefficient:     {unit.GetProperty("coefficient")}");
Console.WriteLine($"Default:         {unit.GetProperty("default")}");
