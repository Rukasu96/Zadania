using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSamochody
{
    internal class Parking
    {
        public Dictionary<char, Car> ParkingSlots;


        public Parking()
        {
            ParkingSlots = new Dictionary<char, Car>();
            ParkingSlots.Add('A', null);
            ParkingSlots.Add('B', null);
            ParkingSlots.Add('C', null);
            ParkingSlots.Add('D', null);
            ParkingSlots.Add('E', null);
            ParkingSlots.Add('F', null);
        }

        public void AddCar(Car car, char slot)
        {
            if (ParkingSlots[slot] != null)
            {
                throw new Exception("Slot is occupied");
            }
            else
            {
                ParkingSlots[slot] = car;
            }
        }

        public void RemoveCar(char slot)
        {
            if (ParkingSlots[slot] == null)
            {
                return;
            }
            else
            {
                ParkingSlots[slot] = null;
            }
        }

        public void UseFirstEmptySlot(Car car)
        {
            var firstEmptySlot = ParkingSlots.First(x => x.Value == null);
            if(firstEmptySlot.Value == null)
            {
                ParkingSlots[firstEmptySlot.Key] = car;
            }
            else
            {
                throw new Exception("No empty slot");
            }
        }


        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder();
            var parkingss = ParkingSlots.Select(x => x).ToList();
            Console.WriteLine("Stan parkingu: ");
            parkingss.ForEach(x => sb.AppendLine($"{x.Key} {x.Value}"));
            return sb.ToString();
        }


    }
}
