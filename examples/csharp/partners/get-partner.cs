using System.Net.Http.Json;
using System.Text.Json;

// GET /directories/partners/{code}
// Returns partner details.

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey  = "{your-api-key}";
var code    = "P100"; // partner code to fetch

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var response = await client.GetAsync($"/directories/partners/{Uri.EscapeDataString(code)}");
if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
{
    Console.WriteLine("Partner not found.");
    return;
}

response.EnsureSuccessStatusCode();

var partner = await response.Content.ReadFromJsonAsync<JsonElement>();
Console.WriteLine($"Partner: {partner.GetProperty("code").GetString()} - {partner.GetProperty("name").GetString()}");
