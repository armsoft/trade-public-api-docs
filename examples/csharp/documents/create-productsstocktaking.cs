using System.Net.Http.Json;

// POST /documents/productsstocktaking

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey = "YOUR_API_KEY";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var request = new
{
    date = "2026-11-09",
    state = 2,
    storage = "01",
    currency = "AMD",
    currencyExchangeRate = 1,
    currencyExchangeBase = 1,
    itemList = new[]
    {
        new { code = "1001", unit = "pcs", actualQuantity = 48, price = 250, actualAmount = 12000 },
        new { code = "1002", unit = "pcs", actualQuantity = 100, price = 300, actualAmount = 30000 }
    }
};

var response = await client.PostAsJsonAsync("/documents/productsstocktaking", request);
response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());
