using System.Net.Http.Json;
using System.Text.Json;

// POST /directories/products/measureunits/list
// Returns measure units for the specified product codes.

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey  = "{your-api-key}";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var filters = new
{
    itemCodes = new[] { "1001", "1002" },
    pageSize  = 5000
};

var response = await client.PostAsJsonAsync("/directories/products/measureunits/list", filters);
response.EnsureSuccessStatusCode();

using var json = await response.Content.ReadAsStreamAsync();
using var doc  = await JsonDocument.ParseAsync(json);

var root    = doc.RootElement;
var hasMore = root.TryGetProperty("hasMore", out var hm) && hm.GetBoolean();

foreach (var unit in root.GetProperty("data").EnumerateArray())
{
    Console.WriteLine(
        $"Item {unit.GetProperty("itemCode").GetString()} — " +
        $"{unit.GetProperty("unitMeasure").GetString()} " +
        $"({unit.GetProperty("unitMeasureAbbreviation").GetString()}) " +
        $"coeff={unit.GetProperty("coefficient")}");
}

if (hasMore)
{
    var pageId = root.GetProperty("id").GetString();
    Console.WriteLine($"More pages available. Pagination id: {pageId}");
}
