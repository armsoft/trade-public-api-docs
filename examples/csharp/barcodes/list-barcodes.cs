// Example: list barcodes

var client = new BarcodesClient("{your-api-key}");
var doc = await client.ListAsync(new { limit = 50 });
foreach (var item in doc.RootElement.GetProperty("data").EnumerateArray())
{
    Console.WriteLine(item.GetProperty("code").GetString());
}
