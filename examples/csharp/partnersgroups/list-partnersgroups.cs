// Example: list partner groups

var client = new PartnersGroupsClient("{your-api-key}");
var doc = await client.ListAsync(new { limit = 50 });
foreach (var item in doc.RootElement.GetProperty("data").EnumerateArray())
    Console.WriteLine(item.GetProperty("code").GetString());
