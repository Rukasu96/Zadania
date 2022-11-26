using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamBank
{
    internal class Bank : IPublisher
    {
        private List<ISubscriber> subscribers;

        public Bank()
        {
            subscribers = new List<ISubscriber>();
        }

        public void addSubscriber(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void removeSubscriber(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void SendMessage(string message)
        {
            foreach(var subscriber in subscribers)
            {
                subscriber.update(message);
            }
        }
    }
}
