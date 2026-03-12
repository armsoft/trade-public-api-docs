using System.Net.Http.Json;
using System.Text.Json;

// PUT /directories/partners/{partnerCode}/contracts/{contractCode}
// Update a contract.

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey  = "{your-api-key}";
var partnerCode = "P100";
var contractCode = "C001";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var updated = new
{
    contractName = "Updated supply terms",
    date = "2026-04-01"
};

var response = await client.PutAsJsonAsync(
    $"/directories/partners/{Uri.EscapeDataString(partnerCode)}/contracts/{Uri.EscapeDataString(contractCode)}",
    updated);
if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
{
    Console.WriteLine("Contract not found.");
    return;
}

response.EnsureSuccessStatusCode();
var contract = await response.Content.ReadFromJsonAsync<JsonElement>();
Console.WriteLine($"Updated contract: {contract.GetProperty("contractCode").GetString()}");
