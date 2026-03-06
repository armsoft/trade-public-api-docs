using System.Net.Http.Json;
using System.Text.Json;

// POST /directories/products
// Creates a new product and returns the created record.

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey  = "{your-api-key}";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var newProduct = new
{
    code            = "1003",
    name            = "New Product Name",
    type            = "1",          // 1 = product, 2 = service
    group           = "110",
    baseUnitMeasure = "001",
    vat             = true,
    showInPriceLists = true,
    externalCode    = "EXT-1003"
};

var response = await client.PostAsJsonAsync("/directories/products", newProduct);

if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
{
    Console.WriteLine("A product with that code already exists.");
    return;
}

response.EnsureSuccessStatusCode(); // expects 201 Created

var created = await response.Content.ReadFromJsonAsync<JsonElement>();
Console.WriteLine($"Created product id: {created.GetProperty("id")}");
Console.WriteLine($"Code: {created.GetProperty("code").GetString()}");
