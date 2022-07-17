using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drukarki
{
    internal class Drukarka:Urządzenie, IDrukowanie
    {
        private int IloscTuszu;


        public Drukarka(string model, string marka, int iloscTuszu):base(model, marka)
        {
            IloscTuszu = iloscTuszu;

        }

        public string Drukuj()
        {
            if(IloscTuszu <= 0)
            {
                throw new TooSmallValue();
            }

            return "Drukarka zaczyna drukować.";
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
