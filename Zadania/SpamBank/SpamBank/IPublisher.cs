using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamBank
{
    internal interface IPublisher
    {

        void addSubscriber(ISubscriber subscriber);
        void removeSubscriber(ISubscriber subscriber);

    }
}
