// Example: get a barcode

var client = new BarcodesClient("{your-api-key}");
var obj = await client.GetAsync("1234567890123");
if (obj != null) Console.WriteLine(obj);
