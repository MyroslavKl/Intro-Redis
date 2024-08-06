

using RedisDemo1;

var cache = RedisHelper.Database;
await cache.StringSetAsync("Author","Agata Kristi");
var value = await cache.StringGetAsync("Author");
Console.WriteLine(value);