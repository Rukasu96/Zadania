using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja16b
{
    internal interface IChat
    {
        void Join(IUser user);
        void Broadcast(string sender, string message);
        void PrivateMessage(string sender, string receiver, string message);
    }
}
