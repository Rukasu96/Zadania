using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bag
{
    abstract class Item
    {

        private int Weight;
        public int weight 
        {
            get
            {
                return Weight;
            }
            set
            {
                if(value > 0)
                {
                    Weight = value;
                }
            }
        }

        public abstract decimal ItemWeight();

    }
}
