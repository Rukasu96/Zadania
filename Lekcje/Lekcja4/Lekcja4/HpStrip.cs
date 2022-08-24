using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja4
{
    internal class HpStrip : ISubscriber
    {
        public void Update(int hp)
        {
            Console.WriteLine($"Current hp: {hp}/100");
        }
    }
}
