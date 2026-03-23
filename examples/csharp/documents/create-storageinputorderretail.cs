using System.Net.Http.Json;

// POST /documents/storageinputorderretail

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey = "YOUR_API_KEY";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var request = new
{
    documentDate = "2026-03-01",
    storage = "S001",
    lines = new []
    {
        new { itemCode = "1001", quantity = 3, price = 150 }
    }
};

var response = await client.PostAsJsonAsync("/documents/storageinputorderretail", request);
response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());
