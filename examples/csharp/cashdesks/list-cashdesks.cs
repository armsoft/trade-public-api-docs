// Example: list cash desks

var client = new CashDesksClient("{your-api-key}");
var doc = await client.ListAsync(new { limit = 20 });
Console.WriteLine(doc.RootElement);
