// Example: update a cash desk

var client = new CashDesksClient("{your-api-key}");
var updated = await client.UpdateAsync("CD001", new
{
    code = "CD001",
    name = "Main Register",
    address = "1 Main St",
    phone = "555-5678"
});
Console.WriteLine(updated);
