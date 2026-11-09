using System.Net.Http.Json;

// POST /documents/productskitting

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey = "YOUR_API_KEY";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var request = new
{
    date = "2026-11-09",
    state = 2,
    storageOutput = "01",
    storageInput = "01",
    kit = "K001",
    unit = "pcs",
    quantity = 10,
    kitComponents = new[]
    {
        new { code = "1001", unit = "pcs", quantity = 10 },
        new { code = "1002", unit = "pcs", quantity = 20 }
    }
};

var response = await client.PostAsJsonAsync("/documents/productskitting", request);
response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());
