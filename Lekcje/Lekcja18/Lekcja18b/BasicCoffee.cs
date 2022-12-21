using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18b
{
    internal class BasicCoffee : ICoffee
    {
        public double GetCost()
        {
            return 5;
        }

        public string GetDescription()
        {
            return "Kawa";
        }
    }
}
