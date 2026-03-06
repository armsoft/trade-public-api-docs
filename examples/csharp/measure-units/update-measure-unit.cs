using System.Net.Http.Json;
using System.Text.Json;

// PUT /directories/products/{productCode}/measureunits/{unitCode}
// Updates an existing measure unit for a product.

var baseUrl     = "https://api.armsoft.am/trade/v1";
var apiKey      = "{your-api-key}";
var productCode = "1001";
var unitCode    = "002";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var updatedUnit = new
{
    itemCode    = productCode,
    unitMeasure = unitCode,
    coefficient = 0.75m,    // updated coefficient
    @default    = false
};

var response = await client.PutAsJsonAsync(
    $"/directories/products/{Uri.EscapeDataString(productCode)}" +
    $"/measureunits/{Uri.EscapeDataString(unitCode)}",
    updatedUnit);

switch (response.StatusCode)
{
    case System.Net.HttpStatusCode.NotFound:
        Console.WriteLine($"Measure unit '{unitCode}' not found for product '{productCode}'.");
        return;
    case System.Net.HttpStatusCode.Conflict:
        Console.WriteLine("Update conflict — the record may have changed. Retry.");
        return;
}

response.EnsureSuccessStatusCode();

var result = await response.Content.ReadFromJsonAsync<JsonElement>();
Console.WriteLine($"Updated coefficient: {result.GetProperty("coefficient")}");
