using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja15
{
    public class Kurs
    {
        public DateTime Data { get; set; }
        public double Cena { get; set; }

        public override string ToString()
        {
            return Data.ToShortDateString() + " cena: " + Cena + " zł";
        }
    }
}
