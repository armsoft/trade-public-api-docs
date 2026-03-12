// Example: delete a barcode

var client = new BarcodesClient("{your-api-key}");
bool removed = await client.DeleteAsync("1234567890123");
Console.WriteLine("Deleted: " + removed);
