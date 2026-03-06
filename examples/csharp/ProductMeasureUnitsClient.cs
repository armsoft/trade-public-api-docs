using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for the Product Measure Units directory endpoints.
/// Base URL: https://api.armsoft.am/trade/v1
/// </summary>
public class ProductMeasureUnitsClient
{
    private readonly HttpClient _http;

    public ProductMeasureUnitsClient(string apiKey)
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/trade/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
    }

    // -------------------------------------------------------------------------
    // POST /directories/products/measureunits/list
    // -------------------------------------------------------------------------
    /// <summary>Returns the first page of measure units matching the supplied filters.</summary>
    public async Task<JsonDocument> ListAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("/directories/products/measureunits/list", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // POST /directories/products/measureunits/list/nextpage
    // -------------------------------------------------------------------------
    /// <summary>Returns the next page of measure units using a pagination id.</summary>
    public async Task<JsonDocument> ListNextPageAsync(string id)
    {
        var response = await _http.PostAsJsonAsync(
            "/directories/products/measureunits/list/nextpage", new { id });
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // GET /directories/products/{productCode}/measureunits/{unitCode}
    // -------------------------------------------------------------------------
    /// <summary>Returns a single measure unit for a product.</summary>
    public async Task<JsonElement?> GetAsync(string productCode, string unitCode)
    {
        var url = $"/directories/products/{Uri.EscapeDataString(productCode)}" +
                  $"/measureunits/{Uri.EscapeDataString(unitCode)}";
        var response = await _http.GetAsync(url);
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // POST /directories/products/measureunits  → 201 Created
    // -------------------------------------------------------------------------
    /// <summary>Creates a new measure unit for a product.</summary>
    public async Task<JsonElement> CreateAsync(object unit)
    {
        var response = await _http.PostAsJsonAsync("/directories/products/measureunits", unit);
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("A measure unit with that code already exists for this product.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // PUT /directories/products/{productCode}/measureunits/{unitCode}
    // -------------------------------------------------------------------------
    /// <summary>Replaces all fields of an existing measure unit.</summary>
    public async Task<JsonElement> UpdateAsync(string productCode, string unitCode, object unit)
    {
        var url = $"/directories/products/{Uri.EscapeDataString(productCode)}" +
                  $"/measureunits/{Uri.EscapeDataString(unitCode)}";
        var response = await _http.PutAsJsonAsync(url, unit);
        if (response.StatusCode == HttpStatusCode.NotFound)
            throw new KeyNotFoundException($"Measure unit '{unitCode}' not found for product '{productCode}'.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // DELETE /directories/products/{productCode}/measureunits/{unitCode}
    // -------------------------------------------------------------------------
    /// <summary>Permanently deletes a measure unit from a product.</summary>
    /// <returns><c>true</c> if deleted; <c>false</c> if not found.</returns>
    public async Task<bool> DeleteAsync(string productCode, string unitCode)
    {
        var url = $"/directories/products/{Uri.EscapeDataString(productCode)}" +
                  $"/measureunits/{Uri.EscapeDataString(unitCode)}";
        var response = await _http.DeleteAsync(url);
        if (response.StatusCode == HttpStatusCode.NotFound) return false;
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("Cannot delete: measure unit is in use by other records.");
        response.EnsureSuccessStatusCode();
        return true;
    }
}

// =============================================================================
// Usage example
// =============================================================================
// var client = new ProductMeasureUnitsClient("{your-api-key}");
//
// var doc = await client.ListAsync(new
// {
//     itemCodes = new[] { "1001", "1002" },
//     pageSize  = 5000
// });
//
// foreach (var unit in doc.RootElement.GetProperty("data").EnumerateArray())
//     Console.WriteLine(
//         $"Item {unit.GetProperty("itemCode").GetString()} — " +
//         $"{unit.GetProperty("unitMeasure").GetString()} " +
//         $"({unit.GetProperty("unitMeasureAbbreviation").GetString()})");
