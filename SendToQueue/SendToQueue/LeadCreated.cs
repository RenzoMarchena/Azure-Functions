using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.ServiceBus.Messaging;

namespace SendToTopic
{
    public static class LeadCreated
    {
        [FunctionName("LeadCreated")]
        public static void Run([ServiceBusTrigger("LeadsCreated", "Integration", AccessRights.Listen, Connection = "ServiceBusConnectionString")]string mySbMsg, TraceWriter log)
        {
            var topicSender = new AzureServiceBusTopicSender();

            topicSender.SendToTopic("MyTopic");

            log.Info($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
