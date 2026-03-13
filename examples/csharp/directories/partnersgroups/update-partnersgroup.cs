// Example: update a partner group

var client = new PartnersGroupsClient("{your-api-key}");
var updated = await client.UpdateAsync("PG001", new { code = "PG001", name = "Resellers" });
Console.WriteLine(updated);
