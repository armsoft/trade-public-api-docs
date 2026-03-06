using System.Net.Http.Json;
using System.Text.Json;

// POST /directories/products/list
// Returns a paginated list of products matching the supplied filters.

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey  = "{your-api-key}";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var filters = new
{
    showMode = "3",          // 1 = price-list only, 2 = not in price-list, 3 = all
    group    = (string?)null,
    type     = (string?)null,
    codes    = new[] { "1001", "1002" },
    extended = true,
    priceListTypes   = Array.Empty<string>(),
    lastModifiedDate = (DateTimeOffset?)null,
    pageSize = 5000
};

var response = await client.PostAsJsonAsync("/directories/products/list", filters);
response.EnsureSuccessStatusCode();

using var json = await response.Content.ReadAsStreamAsync();
using var doc  = await JsonDocument.ParseAsync(json);

var root    = doc.RootElement;
var hasMore = root.TryGetProperty("hasMore", out var hm) && hm.GetBoolean();
var items   = root.GetProperty("data").EnumerateArray();

foreach (var item in items)
{
    var code = item.GetProperty("code").GetString();
    var name = item.GetProperty("name").GetString();
    Console.WriteLine($"{code} — {name}");
}

if (hasMore)
{
    // Use the returned `id` as the pagination context for the next page.
    var pageId = root.GetProperty("id").GetString();
    Console.WriteLine($"More pages available. Pagination id: {pageId}");
}
