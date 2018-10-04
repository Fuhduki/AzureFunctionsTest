using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsTest
{
    public static class OrcastrationLeakFunctions
    {
        [FunctionName("OrcastrationLeakRun")]
        public static async Task OrcastrationLeakRun([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer,
            [OrchestrationClient] DurableOrchestrationClient client, ILogger log)
        {
            await client.StartNewAsync("LeakOrcastration-Line", null);
            //await client.StartNewAsync("LeakOrcastration-For", null);
            //await client.StartNewAsync("LeakOrcastration-WhenAll", null);
        }

        [FunctionName("LeakOrcastration-Line")]
        public static async Task LeakOrcastrationLine(
            [OrchestrationTrigger] DurableOrchestrationContext content,
            ILogger log)
        {
            log.LogInformation($"------ LeakOrcastration-Line Start");
            //var x = await content.CallActivityAsync<List<int>>("GetIntList", null);
            var x01 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x01}");
            var x02 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x02}");
            var x03 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x03}");
            var x04 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x04}");
            var x05 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x05}");
            var x06 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x06}");
            var x07 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x07}");
            var x08 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x08}");
            var x09 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x09}");
            var x10 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x10}");
            var x11 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x11}");
            var x12 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x12}");
            var x13 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x13}");
            var x14 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x14}");
            var x15 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x15}");
            var x16 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x16}");
            var x17 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x17}");
            var x18 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x18}");
            var x19 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x19}");
            var x20 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x20}");
            var x21 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x21}");
            var x22 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x22}");
            var x23 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x23}");
            var x24 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x24}");
            var x25 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x25}");
            var x26 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x26}");
            var x27 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x27}");
            var x28 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x28}");
            var x29 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x29}");
            var x30 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x30}");
            var x31 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x31}");
            var x32 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x32}");
            var x33 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x33}");
            var x34 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x34}");
            var x35 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x35}");
            var x36 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x36}");
            var x37 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x37}");
            var x38 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x38}");
            var x39 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x39}");
            var x40 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x40}");
            var x41 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x41}");
            var x42 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x42}");
            var x43 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x43}");
            var x44 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x44}");
            var x45 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x45}");
            var x46 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x46}");
            var x47 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x47}");
            var x48 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x48}");
            var x49 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x49}");
            var x50 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x50}");
            var x51 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x51}");
            var x52 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x52}");
            var x53 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x53}");
            var x54 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x54}");
            var x55 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x55}");
            var x56 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x56}");
            var x57 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x57}");
            var x58 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x58}");
            var x59 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x59}");
            var x60 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x60}");
            var x61 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x61}");
            var x62 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x62}");
            var x63 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x63}");
            var x64 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x64}");
            var x65 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x65}");
            var x66 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x66}");
            var x67 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x67}");
            var x68 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x68}");
            var x69 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x69}");
            var x70 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x70}");
            var x71 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x71}");
            var x72 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x72}");
            var x73 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x73}");
            var x74 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x74}");
            var x75 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x75}");
            var x76 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x76}");
            var x77 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x77}");
            var x78 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x78}");
            var x79 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x79}");
            var x80 = await content.CallActivityAsync<int>("GetInt", null);
            log.LogInformation($"{x80}");

            log.LogInformation("------ LeakOrcastration-Line End");
        }

        [FunctionName("LeakOrcastration-For")]
        public static async Task LeakOrcastrationFor(
            [OrchestrationTrigger] DurableOrchestrationContext content,
            ILogger log)
        {
            log.LogInformation($"------ LeakOrcastration-For Start");
            //var x = await content.CallActivityAsync<List<int>>("GetIntList", null);
            for (int i = 0; i < 80; i++)
            {
                var x01 = await content.CallActivityAsync<int>("GetInt", null);
                log.LogInformation($"{x01}");
            }
            log.LogInformation("------ LeakOrcastration-For End");
        }

        [FunctionName("LeakOrcastration-WhenAll")]
        public static async Task LeakOrcastrationWhenAll(
            [OrchestrationTrigger] DurableOrchestrationContext content,
            ILogger log)
        {
            log.LogInformation($"------ LeakOrcastration-WhenAll Start");
            const int count = 80;
            var tasks = new Task<int>[count];
            for (int i = 0; i < count; i++)
            {
                tasks[i] = content.CallActivityAsync<int>("GetInt", null);
            }

            await Task.WhenAll(tasks);

            for (int i = 0; i < count; i++)
            {
                log.LogInformation($"{tasks[i].Result}");
            }

            log.LogInformation("------ LeakOrcastration-WhenAll End");
        }

        [FunctionName("GetInt")]
        public static int GetInt(
            [ActivityTrigger] DurableActivityContext context,
            ILogger log)
        {
            return 10;
        }
    }
}
