using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja16b
{
    internal class ChatUser : IUser
    {
        private IChat chat;
        private List<string> chatlog = new List<string>();

        public string Name { get; }

        public ChatUser(string name)
        {
            Name = name;
        }

        public void PrivateMessage(string receiver, string message)
        {
            chat.PrivateMessage(Name, receiver, message);
        }

        public void Receive(string sender, string message)
        {
            string msg = $"{sender}: {message}";
            Console.WriteLine(msg);
            chatlog.Add(msg);
        }

        public void Say(string message)
        {
            chat.Broadcast(Name, message);
        }

        public void SetChat(IChat chat)
        {
            this.chat = chat;
        }
    }
}
