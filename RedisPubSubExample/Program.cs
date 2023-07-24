using StackExchange.Redis;

ConnectionMultiplexer connection=await ConnectionMultiplexer.ConnectAsync("redis-10968.c56.east-us.azure.cloud.redislabs.com:10968",options =>
{
    options.Password= "SP6TSSIil1ddmvrD6N59Ugt7QkFksnfe";
});
ISubscriber subscriber =connection.GetSubscriber();
while (true)
{
    Console.Write("Mesaj : ");
    string message=Console.ReadLine();
    await subscriber.PublishAsync("mychannel", message);
}