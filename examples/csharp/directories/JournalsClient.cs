using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for Journals endpoints.
/// Base URL: https://api.armsoft.am/trade/v1
/// </summary>
public class JournalsClient
{
    private readonly HttpClient _http;

    public JournalsClient(string apiKey)
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/trade/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
    }

    public async Task<JsonDocument> AllDocumentsAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("/journals/alldocuments", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> AllDocumentsNextPageAsync(object nextPage)
    {
        var response = await _http.PostAsJsonAsync("/journals/alldocuments/nextpage", nextPage);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> EcrChecksAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("/journals/ecrchecks", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> EcrChecksNextPageAsync(object nextPage)
    {
        var response = await _http.PostAsJsonAsync("/journals/ecrchecks/nextpage", nextPage);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }
}

// Usage example:
// var client = new JournalsClient("YOUR_API_KEY");
// var doc = await client.AllDocumentsAsync(new { startDate = "2026-01-01", endDate = "2026-01-31", pageSize = 5000 });
// var next = await client.AllDocumentsNextPageAsync(new { id = doc.RootElement.GetProperty("id").GetString(), close = false });
