using System.Net.Http.Json;

// POST /reports/productsbalances/nextpage

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey = "YOUR_API_KEY";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var request = new
{
    id = "550e8400-e29b-41d4-a716-446655440000",
    close = false
};

var response = await client.PostAsJsonAsync("/reports/productsbalances/nextpage", request);
response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());
