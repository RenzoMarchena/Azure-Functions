using SendToTopicInterfaces;

namespace SendToTopic
{
    public class AzureServiceBusTopicSender : ITopicSender
    {
        public void SendToTopic(string topicName)
        {
            if (string.IsNullOrWhiteSpace(topicName))
                throw new System.Exception();
            return;
        }
    }
}
