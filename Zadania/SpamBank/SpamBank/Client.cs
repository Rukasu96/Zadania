using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamBank
{
    internal class Client : ISubscriber
    {
        private List<string> spam;
        private bool getSpam;
        public string Name { get; set; }

        public Client(string name, bool getSpam, Bank bank)
        {
            Name = name;
            spam = new List<string>();
            this.getSpam = getSpam;

            if(this.getSpam)
            {
                bank.addSubscriber(this);
            }
        }

        public void CheckSpam()
        {
            Console.WriteLine(Name);
            foreach(var message in spam)
            {
                Console.WriteLine(message);
            }

        }

        public void update(string message)
        {
            spam.Add(message);
        }

    }
}
