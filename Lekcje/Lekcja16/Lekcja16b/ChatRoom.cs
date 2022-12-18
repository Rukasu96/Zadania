using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja16b
{
    internal class ChatRoom : IChat
    {
        private List<IUser> users = new List<IUser>();

        public void Broadcast(string sender, string message)
        {
            users.ForEach(x => x.Receive(sender, message));
        }

        public void Join(IUser user)
        {
            users.Add(user);
            user.SetChat(this);
        }

        public void PrivateMessage(string sender, string receiver, string message)
        {
            var user = users.FirstOrDefault(x => x.Name == receiver);
            if(user != null)
            {
                user.Receive(sender, message);
            }
        }
    }
}
