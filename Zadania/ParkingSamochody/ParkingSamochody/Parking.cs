using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSamochody
{
    internal class Parking
    {
        public Dictionary<Car, char> ParkingSlots;


        public Parking()
        {
            ParkingSlots = new Dictionary<Car, char>();
            ParkingSlots.Add(null, 'A');
            ParkingSlots.Add(null, 'B');
            ParkingSlots.Add(null, 'C');
            ParkingSlots.Add(null, 'D');
            ParkingSlots.Add(null, 'E');
            ParkingSlots.Add(null, 'F');
        }

    }
}
