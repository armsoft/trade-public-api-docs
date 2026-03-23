using System.Net.Http.Json;

// POST /journals/ecrchecks

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey = "YOUR_API_KEY";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var request = new
{
    startDate = "2026-01-01",
    endDate = "2026-01-31",
    showPayments = true,
    pageSize = 5000
};

var response = await client.PostAsJsonAsync("/journals/ecrchecks", request);
response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());
