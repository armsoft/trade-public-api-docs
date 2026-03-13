// Example: delete a cash desk

var client = new CashDesksClient("{your-api-key}");
bool ok = await client.DeleteAsync("CD002");
Console.WriteLine("Deleted: " + ok);
