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

        public void WriteMessage()
        {
            bool isFinish = false;
            Console.WriteLine("Wpisz wiadomość dla właścicieli");

            do
            {
                Console.WriteLine("Wiadomość: ");
                string input = Console.ReadLine();

                SendMessage(input);

                Console.WriteLine("Czy napisać kolejną? Y/N");
                input = Console.ReadLine();
                if(input == "Y")
                {
                    isFinish = false;
                }else if(input == "N")
                {
                    isFinish = true;
                }

            } while (isFinish == false);
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
