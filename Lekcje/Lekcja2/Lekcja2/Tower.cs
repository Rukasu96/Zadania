using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2
{
    internal class Tower : IAtakujacy, IObronca
    {
        private const int atack = 10;
        private int durability = 100;

        public void Atakuj(IObronca o)
        {
            if(durability > 0)
            {
                Console.WriteLine("Wieza atakuje z sila " + atack);
                o.PrzyjmijObrazenia(atack);
            }
            else
            {
                Console.WriteLine("Wieza nie moze atakowac");
            }
        }

        public void PrzyjmijObrazenia(int ile)
        {
            if(ile > 0)
            {
                durability -= ile / 2;
                if(durability < 0)
                {
                    durability = 0;
                }
            }
        }

        public override string? ToString()
        {
            return $"Tower {durability}%";
        }
    }
}
