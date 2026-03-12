using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for the Partners directory endpoints.
/// Base URL: https://api.armsoft.am/trade/v1
/// </summary>
public class PartnersClient
{
    private readonly HttpClient _http;

    public PartnersClient(string apiKey)
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/trade/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
    }

    // -------------------------------------------------------------------------
    // POST /directories/partners/list
    // -------------------------------------------------------------------------
    /// <summary>
    /// Returns the first page of partners matching the supplied filters.
    /// </summary>
    public async Task<JsonDocument> ListAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("/directories/partners/list", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // POST /directories/partners/list/nextpage
    // -------------------------------------------------------------------------
    public async Task<JsonDocument> ListNextPageAsync(string id)
    {
        var response = await _http.PostAsJsonAsync("/directories/partners/list/nextpage", new { id });
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // GET /directories/partners/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement?> GetAsync(string code)
    {
        var response = await _http.GetAsync($"/directories/partners/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // POST /directories/partners  -> 201
    // -------------------------------------------------------------------------
    public async Task<JsonElement> CreateAsync(object partner)
    {
        var response = await _http.PostAsJsonAsync("/directories/partners", partner);
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("A partner with that code already exists.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // PUT /directories/partners/{code}
    // -------------------------------------------------------------------------
    public async Task<JsonElement> UpdateAsync(string code, object partner)
    {
        var response = await _http.PutAsJsonAsync(
            $"/directories/partners/{Uri.EscapeDataString(code)}", partner);
        if (response.StatusCode == HttpStatusCode.NotFound)
            throw new KeyNotFoundException($"Partner '{code}' not found.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // DELETE /directories/partners/{code}
    // -------------------------------------------------------------------------
    public async Task<bool> DeleteAsync(string code)
    {
        var response = await _http.DeleteAsync($"/directories/partners/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return false;
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("Cannot delete: partner is referenced by other records.");
        response.EnsureSuccessStatusCode();
        return true;
    }

    // -------------------------------------------------------------------------
    // Contracts operations
    // -------------------------------------------------------------------------

    /// <summary>
    /// List contracts using filters.
    /// </summary>
    public async Task<JsonDocument> ListContractsAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("/directories/partners/contracts/list", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> ListContractsNextPageAsync(string id)
    {
        var response = await _http.PostAsJsonAsync("/directories/partners/contracts/list/nextpage", new { id });
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonElement?> GetContractAsync(string partnerCode, string contractCode)
    {
        var response = await _http.GetAsync($"/directories/partners/{Uri.EscapeDataString(partnerCode)}/contracts/{Uri.EscapeDataString(contractCode)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    public async Task<JsonElement> CreateContractAsync(object contract)
    {
        var response = await _http.PostAsJsonAsync("/directories/partners/contracts", contract);
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("A contract with that code already exists for this partner.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    public async Task<JsonElement> UpdateContractAsync(string partnerCode, string contractCode, object contract)
    {
        var response = await _http.PutAsJsonAsync(
            $"/directories/partners/{Uri.EscapeDataString(partnerCode)}/contracts/{Uri.EscapeDataString(contractCode)}", contract);
        if (response.StatusCode == HttpStatusCode.NotFound)
            throw new KeyNotFoundException("Contract not found.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    public async Task<bool> DeleteContractAsync(string partnerCode, string contractCode)
    {
        var response = await _http.DeleteAsync(
            $"/directories/partners/{Uri.EscapeDataString(partnerCode)}/contracts/{Uri.EscapeDataString(contractCode)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return false;
        response.EnsureSuccessStatusCode();
        return true;
    }
}

// =============================================================================
// Usage example (see individual docs for details)
// =============================================================================
// var client = new PartnersClient("{your-api-key}");
// var partners = await client.ListAsync(new { extended = true });
