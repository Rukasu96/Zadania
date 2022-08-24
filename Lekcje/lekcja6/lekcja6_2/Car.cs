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

        public override bool Equals(object? obj)
        {
            if(obj == this)
            {
                return true;
            }
            if(obj is Car car)
            {
                return brand == car.brand && name == car.name;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(brand, name);
        }
    }
}
