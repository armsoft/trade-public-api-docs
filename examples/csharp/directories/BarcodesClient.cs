using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for the Barcodes directory endpoints.
/// Base URL: https://api.armsoft.am/trade/v1
/// </summary>
public class BarcodesClient
{
    private readonly HttpClient _http;

    public BarcodesClient(string apiKey)
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/trade/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
    }

    // -------------------------------------------------------------------------
    // POST /directories/barcodes/list
    // -------------------------------------------------------------------------
    public async Task<JsonDocument> ListAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("/directories/barcodes/list", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // POST /directories/barcodes/list/nextpage
    // -------------------------------------------------------------------------
    public async Task<JsonDocument> ListNextPageAsync(string id)
    {
        var response = await _http.PostAsJsonAsync("/directories/barcodes/list/nextpage", new { id });
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // GET /directories/barcodes/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement?> GetAsync(string code)
    {
        var response = await _http.GetAsync($"/directories/barcodes/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // POST /directories/barcodes
    // -------------------------------------------------------------------------
    public async Task<JsonElement> CreateAsync(object barcode)
    {
        var response = await _http.PostAsJsonAsync("/directories/barcodes", barcode);
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("A barcode with that code already exists.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // PUT /directories/barcodes/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement> UpdateAsync(string code, object barcode)
    {
        var response = await _http.PutAsJsonAsync(
            $"/directories/barcodes/{Uri.EscapeDataString(code)}", barcode);
        if (response.StatusCode == HttpStatusCode.NotFound)
            throw new KeyNotFoundException($"Barcode '{code}' not found.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // DELETE /directories/barcodes/{code}
    // -------------------------------------------------------------------------
    public async Task<bool> DeleteAsync(string code)
    {
        var response = await _http.DeleteAsync($"/directories/barcodes/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return false;
        response.EnsureSuccessStatusCode();
        return true;
    }
}

// =============================================================================
// Usage example
// =============================================================================
// var client = new BarcodesClient("{your-api-key}");
// var list = await client.ListAsync(new { code = "1234567890123" });
