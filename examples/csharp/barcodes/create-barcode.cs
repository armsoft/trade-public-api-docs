// Example: create barcode

var client = new BarcodesClient("{your-api-key}");
var result = await client.CreateAsync(new
{
    parentCode = "PRD100",
    barcode = "1234567890123"
});
Console.WriteLine(result);
