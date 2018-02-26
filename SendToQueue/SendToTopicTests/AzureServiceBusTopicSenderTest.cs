using SendToTopic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SendToTopicTests
{
    [TestClass]
    public class AzureServiceBusTopicSenderTest
    {
        private AzureServiceBusTopicSender _azureServiceBusTopicSender;

        [TestInitialize]
        public void Init()
        {
            _azureServiceBusTopicSender = new AzureServiceBusTopicSender();
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void SendsMessageToTopic_WithInvalidTopicName_ThrowsException()
        {
            _azureServiceBusTopicSender.SendToTopic(" ");
        }



    }
}
