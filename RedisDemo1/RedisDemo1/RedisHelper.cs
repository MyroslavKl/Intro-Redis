using StackExchange.Redis;

namespace RedisDemo1;

public class RedisHelper
{
    private static IDatabase redisDatabase;

    public static IDatabase Database
    {
        get
        {
            return redisDatabase;
        }
    }

    static RedisHelper()
    {
        var connection = ConnectionMultiplexer.Connect("localhost:6379");
        redisDatabase = connection.GetDatabase();
    }
}