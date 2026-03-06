using System.Net.Http.Json;
using System.Text.Json;

// PUT /directories/products/{code}
// Replaces a product's data. Sends the full product object.

var baseUrl     = "https://api.armsoft.am/trade/v1";
var apiKey      = "{your-api-key}";
var productCode = "1001";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

// First fetch the existing record so we don't accidentally blank out fields.
var getResponse = await client.GetAsync($"/directories/products/{Uri.EscapeDataString(productCode)}");
getResponse.EnsureSuccessStatusCode();

// Deserialise to a mutable dictionary so we can patch individual fields.
var existing = await getResponse.Content.ReadFromJsonAsync<Dictionary<string, JsonElement>>()
    ?? throw new InvalidOperationException("Failed to read product.");

// Modify the desired field(s).
var updated = new
{
    code             = productCode,
    name             = "Updated Product Name",
    type             = existing["type"].GetString(),
    group            = existing["group"].GetString(),
    baseUnitMeasure  = existing["baseUnitMeasure"].GetString(),
    vat              = existing["vat"].ValueKind is JsonValueKind.True or JsonValueKind.False
                           ? existing["vat"].GetBoolean()
                           : (bool?)null,
    showInPriceLists = existing.ContainsKey("showInPriceLists") && existing["showInPriceLists"].GetBoolean()
};

var putResponse = await client.PutAsJsonAsync(
    $"/directories/products/{Uri.EscapeDataString(productCode)}", updated);

if (putResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
{
    Console.WriteLine($"Product '{productCode}' not found.");
    return;
}

putResponse.EnsureSuccessStatusCode();

var result = await putResponse.Content.ReadFromJsonAsync<JsonElement>();
Console.WriteLine($"Updated: {result.GetProperty("name").GetString()}");
