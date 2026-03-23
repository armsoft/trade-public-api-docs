using System.Net.Http.Json;
using System.Text.Json;

// POST /journals/alldocuments
// Returns journal rows for documents.

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey = "YOUR_API_KEY";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var request = new
{
    startDate = "2026-01-01",
    endDate = "2026-01-31",
    pageSize = 5000
};

var response = await client.PostAsJsonAsync("/journals/alldocuments", request);
response.EnsureSuccessStatusCode();

var result = await response.Content.ReadAsStringAsync();
Console.WriteLine(result);
