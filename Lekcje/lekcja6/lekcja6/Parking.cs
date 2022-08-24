using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja6
{
    public class Parking : IEnumerable<Car>
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(Car c)
        {
            cars.Add(c);
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
