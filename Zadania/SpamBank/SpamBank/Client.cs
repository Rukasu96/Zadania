using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamBank
{
    internal class Client : ISubscriber
    {
        private List<string> Spam;

        public string Name { get; set; }

        public Client(string name)
        {
            Name = name;
            Spam = new List<string>();
        }

        public void CheckSpam()
        {
            Console.WriteLine(Name);
            foreach(var message in Spam)
            {
                Console.WriteLine(message);
            }

        }

        public void update(string message)
        {
            Spam.Add(message);
        }

    }
}
