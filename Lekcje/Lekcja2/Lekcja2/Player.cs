using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2
{
    internal class Player : IObronca
    {
        private int hp;
        private string name;

        public Player(string name)
        {
            this.Hp = 100;
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }

        public void PrzyjmijObrazenia(int ile)
        {
            if(ile > 0)
            {
                Console.WriteLine(name + " przyjmuje obrazenia o sile: " + ile);
                Hp -= ile;
                if(Hp < 0)
                {
                    Hp = 0;
                }
            }
        }

        public override string? ToString()
        {
            return $"{Name} hp: {Hp}/100";
        }
    }
}
