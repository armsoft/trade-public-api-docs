using System.Net.Http.Json;
using System.Text.Json;

// PUT /directories/partners/{code}
// Replace partner fields.

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey  = "{your-api-key}";
var code    = "P100";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var updated = new
{
    name = "Acme Corp. [updated]",
    fullName = "Acme Corporation Ltd.",
    supplier = true,
    customer = false
};

var response = await client.PutAsJsonAsync($"/directories/partners/{Uri.EscapeDataString(code)}", updated);
if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
{
    Console.WriteLine("Partner not found.");
    return;
}
response.EnsureSuccessStatusCode();

var partner = await response.Content.ReadFromJsonAsync<JsonElement>();
Console.WriteLine($"Updated partner: {partner.GetProperty("code").GetString()} - {partner.GetProperty("name").GetString()}");
