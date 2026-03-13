using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for the Products directory endpoints.
/// Base URL: https://api.armsoft.am/trade/v1
/// </summary>
public class ProductsClient
{
    private readonly HttpClient _http;

    public ProductsClient(string apiKey)
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/trade/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
    }

    // -------------------------------------------------------------------------
    // POST /directories/products/list
    // -------------------------------------------------------------------------
    /// <summary>
    /// Returns the first page of products matching the supplied filters.
    /// </summary>
    /// <param name="filters">
    /// Filter object. <c>showMode</c> is required.
    /// </param>    
    public async Task<JsonDocument> ListAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("/directories/products/list", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // POST /directories/products/list/nextpage
    // -------------------------------------------------------------------------
    /// <summary>Returns the next page of a products list using a pagination id.</summary>
    /// <param name="id">Pagination context id returned by a previous list call.</param>
    public async Task<JsonDocument> ListNextPageAsync(string id)
    {
        var response = await _http.PostAsJsonAsync("/directories/products/list/nextpage", new { id });
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    // -------------------------------------------------------------------------
    // GET /directories/products/{code}
    // -------------------------------------------------------------------------
    /// <summary>Returns the full details of a single product.</summary>
    public async Task<JsonElement?> GetAsync(string code)
    {
        var response = await _http.GetAsync($"/directories/products/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return null;
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // POST /directories/products  → 201 Created
    // -------------------------------------------------------------------------
    /// <summary>Creates a new product and returns the created record.</summary>
    public async Task<JsonElement> CreateAsync(object product)
    {
        var response = await _http.PostAsJsonAsync("/directories/products", product);
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("A product with that code already exists.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // PUT /directories/products/{code}
    // -------------------------------------------------------------------------
    /// <summary>Replaces all fields of an existing product.</summary>
    public async Task<JsonElement> UpdateAsync(string code, object product)
    {
        var response = await _http.PutAsJsonAsync(
            $"/directories/products/{Uri.EscapeDataString(code)}", product);
        if (response.StatusCode == HttpStatusCode.NotFound)
            throw new KeyNotFoundException($"Product '{code}' not found.");
        response.EnsureSuccessStatusCode();
        return (await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync())).RootElement;
    }

    // -------------------------------------------------------------------------
    // DELETE /directories/products/{code}
    // -------------------------------------------------------------------------
    /// <summary>Permanently deletes a product.</summary>
    /// <returns><c>true</c> if deleted; <c>false</c> if not found.</returns>
    public async Task<bool> DeleteAsync(string code)
    {
        var response = await _http.DeleteAsync(
            $"/directories/products/{Uri.EscapeDataString(code)}");
        if (response.StatusCode == HttpStatusCode.NotFound) return false;
        if (response.StatusCode == HttpStatusCode.Conflict)
            throw new InvalidOperationException("Cannot delete: product is referenced by other records.");
        response.EnsureSuccessStatusCode();
        return true;
    }
}

// =============================================================================
// Usage example
// =============================================================================
// var client = new ProductsClient("{your-api-key}");
//
// // Fetch all products (showMode 3 = all)
// var doc = await client.ListAsync(new
// {
//     showMode        = "3",
//     extended        = true,
//     codes           = new[] { "1001", "1002" },
//     priceListTypes  = Array.Empty<string>(),
//     pageSize        = 5000
// });
//
// bool hasMore = doc.RootElement.TryGetProperty("hasMore", out var hm) && hm.GetBoolean();
// foreach (var item in doc.RootElement.GetProperty("data").EnumerateArray())
//     Console.WriteLine($"{item.GetProperty("code").GetString()} — {item.GetProperty("name").GetString()}");
//
// // Paginate
// while (hasMore)
// {
//     var pageId = doc.RootElement.GetProperty("id").GetString()!;
//     doc     = await client.ListNextPageAsync(pageId);
//     hasMore = doc.RootElement.TryGetProperty("hasMore", out hm) && hm.GetBoolean();
//     foreach (var item in doc.RootElement.GetProperty("data").EnumerateArray())
//         Console.WriteLine(item.GetProperty("code").GetString());
// }
