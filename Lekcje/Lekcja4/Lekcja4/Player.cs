using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja4
{
    internal class Player : IPublisher
    {
        private int hp;
        private List<ISubscriber> subscribers;

        public event Action<int> OnHpChange;

        public Player()
        {
            hp = 100;
            subscribers = new List<ISubscriber>();
        }

        public void AddSubscriber(ISubscriber observer)
        {
            subscribers.Add(observer);
        }

        public void NotifySubscribers()
        {
            foreach (var sub in subscribers)
            {
                sub.Update(hp);
            }
        }

        public void Hit(int attack)
        {
            hp -= attack;
            if(hp < 0)
            {
                hp = 0;
            }
            NotifySubscribers();
            OnHpChange?.Invoke(hp);
        }
    }
}
