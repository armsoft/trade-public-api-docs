using System.Net.Http.Json;
using System.Text.Json;

// GET /directories/partners/{partnerCode}/contracts/{contractCode}
// Retrieve a single contract.

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey  = "{your-api-key}";
var partnerCode = "P100";
var contractCode = "C001";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var response = await client.GetAsync($"/directories/partners/{Uri.EscapeDataString(partnerCode)}/contracts/{Uri.EscapeDataString(contractCode)}");
if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
{
    Console.WriteLine("Contract not found.");
    return;
}

response.EnsureSuccessStatusCode();

var contract = await response.Content.ReadFromJsonAsync<JsonElement>();
Console.WriteLine($"Contract: {contract.GetProperty("contractCode").GetString()} for partner {contract.GetProperty("partnerCode").GetString()}");
