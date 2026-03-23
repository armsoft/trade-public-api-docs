using System.Net.Http.Json;

// GET /documents/invoice/{isn}

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey = "YOUR_API_KEY";
var isn = "550e8400-e29b-41d4-a716-446655440000";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var response = await client.GetAsync($"/documents/invoice/{isn}");
response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());
