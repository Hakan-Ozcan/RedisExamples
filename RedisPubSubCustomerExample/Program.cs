using StackExchange.Redis;

ConnectionMultiplexer connection = await ConnectionMultiplexer.ConnectAsync("redis-10968.c56.east-us.azure.cloud.redislabs.com:10968", options =>
{
    options.Password = "SP6TSSIil1ddmvrD6N59Ugt7QkFksnfe";
});
ISubscriber subscriber = connection.GetSubscriber();

await subscriber.SubscribeAsync("mychannel", (channel, message) =>
{
    Console.WriteLine(message);
});
Console.Read();