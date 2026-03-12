using System.Net.Http.Json;
using System.Text.Json;

// POST /directories/partners/contracts
// Creates a contract for a partner.

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey  = "{your-api-key}";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var newContract = new
{
    partnerCode = "P100",
    contractCode = "C001",
    contractName = "Standard supply",
    date = "2026-03-01"
};

var response = await client.PostAsJsonAsync("/directories/partners/contracts", newContract);
if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
{
    Console.WriteLine("A contract with that code already exists for this partner.");
    return;
}

response.EnsureSuccessStatusCode(); // expects 201 Created

var created = await response.Content.ReadFromJsonAsync<JsonElement>();
Console.WriteLine($"Created contract: {created.GetProperty("contractCode").GetString()} for partner {created.GetProperty("partnerCode").GetString()}");
