using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Bag
{
    class Shield : Item
    {
        public Shield(string name, int blockValue)
        {
            Name = name;
            BlockValue = blockValue;
            weight = 20;
        }

        private string Name;
        private int BlockValue;

        public override decimal ItemWeight()
        {
            return weight;
        }

    }
}
