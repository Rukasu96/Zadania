using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja6
{
    public class Car
    {
        private string brand;
        private string name;

        public Car(string brand, string name)
        {
            this.brand = brand;
            this.name = name;
        }

        public override string ToString()
        {
            return $"{brand} {name}";
        }
    }
}
