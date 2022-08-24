using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2
{
    internal class Knight : Player, IAtakujacy
    {
        private int atak;

        public Knight(string name, int atak) : base(name)
        {
            this.atak = atak;
        }

        public void Atakuj(IObronca o)
        {
            Console.WriteLine(Name + " atakuje z sila " + atak);
            o.PrzyjmijObrazenia(atak);
        }
    }
}
