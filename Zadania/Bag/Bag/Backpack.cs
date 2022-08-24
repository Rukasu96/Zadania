using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bag
{
    class Backpack:Item
    {
        public Backpack()
        {
            Items = new List<Item>();
            weight = 10;
        }

        private List<Item> Items;

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public override decimal ItemWeight()
        {
            foreach (Item item in Items)
            {
                weight += (int)item.ItemWeight();
            }
            return weight;
        }

    }
}
