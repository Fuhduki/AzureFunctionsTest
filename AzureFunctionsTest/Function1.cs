
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace AzureFunctionsTest
{
    public static class Function1
    {
        [FunctionName("Function-Begin")]
        public static async Task<IActionResult> Begin(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]
            HttpRequest req,
            [OrchestrationClient] DurableOrchestrationClient client, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            await client.StartNewAsync("Function-StartOrchestration", null);
            return new OkObjectResult($"Orchestration Start.");
        }

        [FunctionName("Function-StartOrchestration")]
        public static async Task StartOrchestration(
            [OrchestrationTrigger] DurableOrchestrationContext content,
            ILogger log)
        {
            var tassAndMessageList = await content.CallActivityAsync<IEnumerable<(TestData, string, string)>>("Function-GetList", null);
            var sendGridTasks =
                tassAndMessageList.Select(elem => content.CallActivityAsync("Function-RunActivity", elem));
            await Task.WhenAll(sendGridTasks);
        }

        [FunctionName("Function-GetList")]
        public static async Task<IEnumerable<(TestData, string, string)>> GetList(
            [ActivityTrigger] DurableActivityContext context,
            ILogger log)
        {
            return new List<(TestData, string, string)>();
        }

        [FunctionName("Function-RunActivity")]
        public static async Task RunActivity(
            [ActivityTrigger] DurableActivityContext context,
            ILogger log)
        {
            return;
        }

        public class TestData
        {
            public string Data { get; set; }
        }

    }
}
