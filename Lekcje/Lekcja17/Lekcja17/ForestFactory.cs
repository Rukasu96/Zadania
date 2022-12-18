using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17
{
    internal class ForestFactory : IBiomeFactory
    {
        public IBlock CreateBlock()
        {
            return new Grass();
        }

        public IEnemy CreateEnemy()
        {
            return new Bunny();
        }

        public ITree CreateTree()
        {
            return new Oak();
        }
    }
}
