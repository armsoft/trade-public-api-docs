using System.Net.Http.Json;
using System.Text.Json;

// DELETE /directories/partners/{partnerCode}/contracts/{contractCode}
// Delete a partner contract.

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey  = "{your-api-key}";
var partnerCode = "P100";
var contractCode = "C001";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var response = await client.DeleteAsync(
    $"/directories/partners/{Uri.EscapeDataString(partnerCode)}/contracts/{Uri.EscapeDataString(contractCode)}");
if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
{
    Console.WriteLine("Contract not found.");
    return;
}
response.EnsureSuccessStatusCode();
Console.WriteLine("Contract deleted.");
