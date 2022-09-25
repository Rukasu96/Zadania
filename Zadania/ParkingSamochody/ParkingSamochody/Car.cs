using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSamochody
{
    internal class Car
    {
        private string mark;
        private string model;
        private string registration;

        public Car(string mark, string model, string registration)
        {
            this.mark = mark;
            this.model = model;
            this.registration = registration;
        }

        public override string ToString()
        {
            return $"{mark} {model}";
        }
    }
}
