using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for the CashDesks directory endpoints.
/// Base URL: https://api.armsoft.am/trade/v1
/// </summary>
public class CashDesksClient
{
    private readonly HttpClient _http;

    public CashDesksClient(string apiKey)
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/trade/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
    }

    /// <summary>
    /// Returns all cash desks. Pass <paramref name="showAlsoClosed"/> as false to skip
    /// cash desks marked as closed (isClosed = true); the API includes them by default.
    /// </summary>
    public async Task<JsonElement?> GetAllAsync(bool showAlsoClosed = true)
    {
        var response = await _http.GetAsync(
            $"/directories/cashdesks?showAlsoClosed={showAlsoClosed.ToString().ToLowerInvariant()}");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    public async Task<JsonElement?> GetAsync(string code)
    {
        var response = await _http.GetAsync($"/directories/cashdesks/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    public async Task<JsonElement> CreateAsync(object item)
    {
        var response = await _http.PostAsJsonAsync("/directories/cashdesks", item);
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("A cash desk with that code already exists.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    public async Task<JsonElement> UpdateAsync(string code, object item)
    {
        var response = await _http.PutAsJsonAsync(
            $"/directories/cashdesks/{Uri.EscapeDataString(code)}", item);
        if (response.StatusCode == HttpStatusCode.NotFound)
            throw new KeyNotFoundException($"Cash desk '{code}' not found.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    public async Task<bool> DeleteAsync(string code)
    {
        var response = await _http.DeleteAsync($"/directories/cashdesks/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return false;
        response.EnsureSuccessStatusCode();
        return true;
    }
}

// Usage example:
// var client = new CashDesksClient("{your-api-key}");
