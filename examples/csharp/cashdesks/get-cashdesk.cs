// Example: get a cash desk

var client = new CashDesksClient("{your-api-key}");
var obj = await client.GetAsync("CD001");
Console.WriteLine(obj);
