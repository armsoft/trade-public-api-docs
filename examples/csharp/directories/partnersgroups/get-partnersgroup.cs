// Example: get a partner group

var client = new PartnersGroupsClient("{your-api-key}");
var obj = await client.GetAsync("PG001");
Console.WriteLine(obj);


// Example: get all partner groups

var client = new PartnersGroupsClient("{your-api-key}");
var obj = await client.GetAllAsync();
Console.WriteLine(obj);
