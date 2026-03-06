using System.Net.Http.Json;
using System.Text.Json;

// POST /directories/products/measureunits
// Creates a new measure unit for a product.

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey  = "{your-api-key}";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var newUnit = new
{
    itemCode    = "1001",
    unitMeasure = "002",
    coefficient = 0.5m,
    @default    = false
};

var response = await client.PostAsJsonAsync("/directories/products/measureunits", newUnit);

if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
{
    Console.WriteLine("A measure unit with that code already exists for this product.");
    return;
}

response.EnsureSuccessStatusCode(); // expects 201 Created

var created = await response.Content.ReadFromJsonAsync<JsonElement>();
Console.WriteLine($"Created measure unit: {created.GetProperty("unitMeasure").GetString()} " +
                  $"for item {created.GetProperty("itemCode").GetString()}");
