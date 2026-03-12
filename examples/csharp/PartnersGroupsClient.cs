using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for the PartnersGroups directory endpoints.
/// Base URL: https://api.armsoft.am/trade/v1
/// </summary>
public class PartnersGroupsClient
{
    private readonly HttpClient _http;

    public PartnersGroupsClient(string apiKey)
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/trade/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
    }

    public async Task<JsonDocument> ListAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("/directories/partnersgroups/list", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> ListNextPageAsync(string id)
    {
        var response = await _http.PostAsJsonAsync("/directories/partnersgroups/list/nextpage", new { id });
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonElement?> GetAsync(string code)
    {
        var response = await _http.GetAsync($"/directories/partnersgroups/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    public async Task<JsonElement> CreateAsync(object item)
    {
        var response = await _http.PostAsJsonAsync("/directories/partnersgroups", item);
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("A partner group with that code already exists.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    public async Task<JsonElement> UpdateAsync(string code, object item)
    {
        var response = await _http.PutAsJsonAsync(
            $"/directories/partnersgroups/{Uri.EscapeDataString(code)}", item);
        if (response.StatusCode == HttpStatusCode.NotFound)
            throw new KeyNotFoundException($"Partner group '{code}' not found.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    public async Task<bool> DeleteAsync(string code)
    {
        var response = await _http.DeleteAsync($"/directories/partnersgroups/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return false;
        response.EnsureSuccessStatusCode();
        return true;
    }
}

// Usage example:
// var client = new PartnersGroupsClient("{your-api-key}");
