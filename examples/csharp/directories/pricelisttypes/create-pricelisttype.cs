// Example: create a cash desk

var client = new CashDesksClient("{your-api-key}");
var result = await client.CreateAsync(new
{
    code = "CD002",
    name = "Front Register",
    address = "1 Main St",
    phone = "555-1234"
});
Console.WriteLine(result);
