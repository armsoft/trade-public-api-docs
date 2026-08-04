// Example: get a cash desk

var client = new CashDesksClient("{your-api-key}");
var obj = await client.GetAsync("CD001");
Console.WriteLine(obj);


// Example: get all cash desks (closed ones included by default)

var client = new CashDesksClient("{your-api-key}");
var obj = await client.GetAllAsync();
Console.WriteLine(obj);


// Example: get only cash desks that are not closed

var client = new CashDesksClient("{your-api-key}");
var openOnly = await client.GetAllAsync(showAlsoClosed: false);
Console.WriteLine(openOnly);
