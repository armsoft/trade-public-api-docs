// Example: update a barcode

var client = new BarcodesClient("{your-api-key}");
var updated = await client.UpdateAsync("1234567890123", new
{
    parentCode = "PRD101",
    barcode = "1234567890123"
});
Console.WriteLine(updated);
