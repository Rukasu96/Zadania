using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja15
{
    public class ConsoleDisplay : IDisplay
    {
        public void Show(Kurs[] kursy)
        {
            foreach (var kurs in kursy)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
