using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bag
{
    class Sword:Item
    {
        public Sword(int damage)
        {
            Damage = damage;
        }

        private decimal Damage;

        public override decimal ItemWeight()
        {
            decimal d = new decimal(1.2);
            return d * Damage;
        }


    }
}
