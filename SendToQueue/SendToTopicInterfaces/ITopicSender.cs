using System;
using System.Collections.Generic;
using System.Text;

namespace SendToTopicInterfaces
{
    public interface ITopicSender
    {
        void SendToTopic(string topicName);
    }
}
