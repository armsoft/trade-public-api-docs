using System.Net.Http.Json;

// POST /reports/partnersbalances

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey = "YOUR_API_KEY";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var request = new
{
    date = "2026-02-01",
    reportCurrency = "AMD",
    pageSize = 5000
};

var response = await client.PostAsJsonAsync("/reports/partnersbalances", request);
response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());
