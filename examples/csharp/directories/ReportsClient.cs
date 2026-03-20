using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

/// <summary>
/// Client for Reports endpoints.
/// Base URL: https://api.armsoft.am/trade/v1
/// </summary>
public class ReportsClient
{
    private readonly HttpClient _http;

    public ReportsClient(string apiKey)
    {
        _http = new HttpClient { BaseAddress = new Uri("https://api.armsoft.am/trade/v1") };
        _http.DefaultRequestHeaders.Add("apiKey", apiKey);
    }

    public async Task<JsonDocument> PartnersBalancesAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("/reports/partnersbalances", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> PartnersBalancesNextPageAsync(object nextPage)
    {
        var response = await _http.PostAsJsonAsync("/reports/partnersbalances/nextpage", nextPage);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> ProductsBalancesAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("/reports/productsbalances", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> ProductsBalancesNextPageAsync(object nextPage)
    {
        var response = await _http.PostAsJsonAsync("/reports/productsbalances/nextpage", nextPage);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> ProductsBalancesShortAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("/reports/productsbalances/short", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> ProductsBalancesShortNextPageAsync(object nextPage)
    {
        var response = await _http.PostAsJsonAsync("/reports/productsbalances/short/nextpage", nextPage);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> PriceListAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("/reports/pricelist", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> PriceListNextPageAsync(object nextPage)
    {
        var response = await _http.PostAsJsonAsync("/reports/pricelist/nextpage", nextPage);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> SalesAnalysisAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("/reports/salesanalysis", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> SalesAnalysisNextPageAsync(object nextPage)
    {
        var response = await _http.PostAsJsonAsync("/reports/salesanalysis/nextpage", nextPage);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> BonusBalancesAsync(object filters)
    {
        var response = await _http.PostAsJsonAsync("/reports/bonusbalances", filters);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }

    public async Task<JsonDocument> BonusBalancesNextPageAsync(object nextPage)
    {
        var response = await _http.PostAsJsonAsync("/reports/bonusbalances/nextpage", nextPage);
        response.EnsureSuccessStatusCode();
        return await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
    }
}

// Usage example:
// var client = new ReportsClient("YOUR_API_KEY");
// var doc = await client.PartnersBalancesAsync(new { date = "2026-02-01", reportCurrency = "AMD", pageSize = 5000 });
