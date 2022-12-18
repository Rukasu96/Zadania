using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17
{
    public class Oak : ITree
    {
        public int Height
        {
            get
            {
                Random r = new Random();
                return r.Next(100);
            }
        }

        public string Color => "brown";
    }

    public class Bunny : IEnemy
    {
        private int hp = 100;
        public int HP { get => hp; set => hp = value; }

        public void Attack()
        {
            Console.WriteLine("Not implemented");
        }
    }

    public class Grass : IBlock
    {
        public string Color => "green";
    }
}
