using System.Net.Http.Json;
using System.Text.Json;

// POST /v1/directories/partners/settlementaccounts/list/nextpage
// Returns next page of settlement accounts.

var baseUrl = "https://api.armsoft.am/trade";
var apiKey  = "{your-api-key}";
var pageId  = "{page-id-from-list-response}";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);
client.DefaultRequestHeaders.Add("Accept-Language", "en-US");

var requestBody = new
{
    id = pageId,
    close = false
};

var response = await client.PostAsJsonAsync("/v1/directories/partners/settlementaccounts/list/nextpage", requestBody);
response.EnsureSuccessStatusCode();

var result = await response.Content.ReadFromJsonAsync<JsonElement>();
Console.WriteLine($"hasMore: {result.GetProperty("hasMore").GetBoolean()}");