using System.Net.Http.Json;
using System.Text.Json;

// POST /directories/partners/list
// Returns partners matching filters.

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey  = "{your-api-key}";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var filters = new
{
    codes = new[] { "P100", "P101" },
    extended = true,
    pageSize = 5000
};

var response = await client.PostAsJsonAsync("/directories/partners/list", filters);
response.EnsureSuccessStatusCode();

using var doc = await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());

var root    = doc.RootElement;
var hasMore = root.TryGetProperty("hasMore", out var hm) && hm.GetBoolean();

foreach (var p in root.GetProperty("data").EnumerateArray())
{
    Console.WriteLine($"{p.GetProperty("code").GetString()} - {p.GetProperty("name").GetString()}");
}

if (hasMore)
{
    var pageId = root.GetProperty("id").GetString();
    Console.WriteLine($"More pages available. ID: {pageId}");
}
