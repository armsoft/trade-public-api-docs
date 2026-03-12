using System.Net.Http.Json;
using System.Text.Json;

// POST /directories/partners
// Creates a new partner.

var baseUrl = "https://api.armsoft.am/trade/v1";
var apiKey  = "{your-api-key}";

using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
client.DefaultRequestHeaders.Add("apiKey", apiKey);

var newPartner = new
{
    code = "P100",
    name = "Acme Corporation",
    fullName = "Acme Corporation Ltd.",
    supplier = true,
    customer = false
};

var response = await client.PostAsJsonAsync("/directories/partners", newPartner);
if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
{
    Console.WriteLine("A partner with that code already exists.");
    return;
}

response.EnsureSuccessStatusCode(); // expects 201 Created

var created = await response.Content.ReadFromJsonAsync<JsonElement>();
Console.WriteLine($"Created partner: {created.GetProperty("code").GetString()} - {created.GetProperty("name").GetString()}");
