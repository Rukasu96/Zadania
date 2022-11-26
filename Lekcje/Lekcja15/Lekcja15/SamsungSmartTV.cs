using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja15
{
    public class SamsungSmartTV : IOdbiornik
    {
        private int nrKanalu;
        public void Wlacz()
        {
            Console.WriteLine("Samsung smartTV uruchamiam sie");
        }

        public void UstawKanal(int nr)
        {
            if (nr < 0 || nr == nrKanalu)
            {
                return;
            }
            nrKanalu = nr;
            Console.WriteLine($"Ustawiam kanal nr {nr}");
        }

        public void Wylacz()
        {
            Console.WriteLine("Samsung martTV wylacz...");
        }
    }
}
