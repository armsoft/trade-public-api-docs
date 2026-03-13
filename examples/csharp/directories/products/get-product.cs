using System.Net.Http.Json;

// GET /directories/products/{code}
// Returns the full details of a single product by its code.

var baseUrl     = "https://api.armsoft.am/trade/v1";
var apiKey      = "{your-api-key}";
var productCode = "1001";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var response = await client.GetAsync($"/directories/products/{Uri.EscapeDataString(productCode)}");

if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
{
    Console.WriteLine($"Product '{productCode}' not found.");
    return;
}

response.EnsureSuccessStatusCode();

var product = await response.Content.ReadFromJsonAsync<JsonElement>();
Console.WriteLine($"Code:          {product.GetProperty("code").GetString()}");
Console.WriteLine($"Name:          {product.GetProperty("name").GetString()}");
Console.WriteLine($"Base UoM:      {product.GetProperty("baseUnitMeasure").GetString()}");
Console.WriteLine($"VAT:           {product.GetProperty("vat")}");
