using System.Net.Http.Json;
using System.Text.Json;

// POST /directories/partners/contracts/list
// Returns partner contracts.

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey  = "{your-api-key}";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var filters = new
{
    partnerCode = "P100",
    pageSize = 5000
};

var response = await client.PostAsJsonAsync("/directories/partners/contracts/list", filters);
response.EnsureSuccessStatusCode();

using var doc = await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
var root    = doc.RootElement;
var hasMore = root.TryGetProperty("hasMore", out var hm) && hm.GetBoolean();

foreach (var ci in root.GetProperty("data").EnumerateArray())
{
    Console.WriteLine($"Contract {ci.GetProperty("contractCode").GetString()} for partner {ci.GetProperty("partnerCode").GetString()}");
}

if (hasMore)
{
    var pageId = root.GetProperty("id").GetString();
    Console.WriteLine($"More pages, id={pageId}");
}
