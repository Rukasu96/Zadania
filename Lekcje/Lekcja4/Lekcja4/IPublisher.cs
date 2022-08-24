using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja4
{
    internal interface IPublisher
    {
        event Action<int> OnHpChange;
        void AddSubscriber(ISubscriber observer);
        void NotifySubscribers();
    }
}
