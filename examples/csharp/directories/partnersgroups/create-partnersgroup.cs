// Example: create a partner group

var client = new PartnersGroupsClient("{your-api-key}");
var result = await client.CreateAsync(new { code = "PG001", name = "Retailers", parent = "" });
Console.WriteLine(result);
