using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17
{
    internal class DesertFactory : IBiomeFactory
    {
        public IBlock CreateBlock()
        {
            return new Sand();
        }

        public IEnemy CreateEnemy()
        {
            return new Scorpion();
        }

        public ITree CreateTree()
        {
            return new Cactus();
        }
    }
}
