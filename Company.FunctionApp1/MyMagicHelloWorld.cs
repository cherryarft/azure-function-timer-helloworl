using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Company.FunctionApp1;

public class MyMagicHelloWorld
{
    [FunctionName("MyMagicHelloWorld")]
    public async Task Run([TimerTrigger("* * * * * *")] TimerInfo ti, ILogger log)
    {
        log.LogInformation("HELLOWORLDMAIGC1.0");
    }
}