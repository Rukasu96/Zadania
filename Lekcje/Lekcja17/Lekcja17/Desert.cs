using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17
{
    public class Cactus : ITree
    {
        public int Height
        {
            get
            {
                return 10;
            }
        }

        public string Color => "green";
    }

    public class Scorpion : IEnemy
    {
        private int hp = 1000;
        public int HP { get => hp; set => hp = value; }

        public void Attack()
        {
            Console.WriteLine("Scorpion attack!!!!");
        }
    }

    public class Sand : IBlock
    {
        public string Color => "yellow";
    }
}
