using System;
using System.Text;

using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.StackExchangeRedis;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public async static void Run([TimerTrigger("*/5 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            RedisCache c = new RedisCache(new RedisCacheOptions { Configuration = "localhost:6375" });
            var data = "krishna";
            await c.SetAsync("k", Encoding.ASCII.GetBytes(data), new DistributedCacheEntryOptions { });
        }
    }
}
