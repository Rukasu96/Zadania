using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja10
{
    internal static class PudelkoExtension
    {
        public static Pudelko Kompresuj(this Pudelko p)
        {
            double bok = Math.Pow(p.V, 1.0 / 3.0);
            return new Pudelko(bok, bok, bok, UnitOfMeasure.meter);
        }

    }
}
