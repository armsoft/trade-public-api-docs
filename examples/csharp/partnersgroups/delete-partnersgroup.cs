// Example: delete a partner group

var client = new PartnersGroupsClient("{your-api-key}");
bool removed = await client.DeleteAsync("PG001");
Console.WriteLine("Deleted: " + removed);
