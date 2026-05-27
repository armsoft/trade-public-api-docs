using System.Net.Http.Json;
using System.Text.Json;

// POST /v1/directories/partners/settlementaccounts/list
// Returns partner settlement accounts (first page).

var baseUrl = "https://api.armsoft.am/trade";
var apiKey  = "{your-api-key}";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);
client.DefaultRequestHeaders.Add("Accept-Language", "en-US");

var requestBody = new
{
    pageSize = 50,
    partnerCodes = new[] { "PARTNER001", "PARTNER002" }
};

var response = await client.PostAsJsonAsync("/v1/directories/partners/settlementaccounts/list", requestBody);
response.EnsureSuccessStatusCode();

var result = await response.Content.ReadFromJsonAsync<JsonElement>();
Console.WriteLine($"pageId: {result.GetProperty("id").GetString()}");
Console.WriteLine($"hasMore: {result.GetProperty("hasMore").GetBoolean()}");