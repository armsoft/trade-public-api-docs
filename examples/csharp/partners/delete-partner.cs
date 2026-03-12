using System.Net.Http.Json;
using System.Text.Json;

// DELETE /directories/partners/{code}
// Delete a partner.

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey  = "{your-api-key}";
var code    = "P100";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var response = await client.DeleteAsync($"/directories/partners/{Uri.EscapeDataString(code)}");
if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
{
    Console.WriteLine("Partner not found (already deleted?)");
    return;
}
if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
{
    Console.WriteLine("Cannot delete: partner is referenced by other records.");
    return;
}
response.EnsureSuccessStatusCode();

Console.WriteLine("Partner deleted.");
