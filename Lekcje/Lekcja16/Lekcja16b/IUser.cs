using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja16b
{
    internal interface IUser
    {
        string Name { get; }
        void Say(string message);
        void PrivateMessage(string receiver, string message);
        void SetChat(IChat chat);
        void Receive(string sender, string message);
    }
}
