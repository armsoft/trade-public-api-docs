using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for the PriceListTypes directory endpoints.
/// Base URL: https://api.armsoft.am/trade/v1
/// </summary>
public class PriceListTypesClient
{
    private readonly HttpClient _http;

    public PriceListTypesClient(string apiKey)
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/trade/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
    }

    public async Task<JsonElement?> GetAllAsync()
    {
        var response = await _http.GetAsync($"/directories/pricelisttypes");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    public async Task<JsonElement?> GetAsync(string code)
    {
        var response = await _http.GetAsync($"/directories/pricelisttypes/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    public async Task<JsonElement> CreateAsync(object item)
    {
        var response = await _http.PostAsJsonAsync("/directories/pricelisttypes", item);
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("A price list type with that code already exists.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    public async Task<JsonElement> UpdateAsync(string code, object item)
    {
        var response = await _http.PutAsJsonAsync(
            $"/directories/pricelisttypes/{Uri.EscapeDataString(code)}", item);
        if (response.StatusCode == HttpStatusCode.NotFound)
            throw new KeyNotFoundException($"Price list type '{code}' not found.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    public async Task<bool> DeleteAsync(string code)
    {
        var response = await _http.DeleteAsync($"/directories/pricelisttypes/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return false;
        response.EnsureSuccessStatusCode();
        return true;
    }
}

// Usage example:
// var client = new PriceListTypesClient("{your-api-key}");
