using System.Net.Http.Json;

// POST /reports/productsbalances

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey = "YOUR_API_KEY";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var request = new
{
    date = "2026-02-01",
    pageSize = 5000,
    storages = new[] { "S001" }
};

var response = await client.PostAsJsonAsync("/reports/productsbalances", request);
response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());
