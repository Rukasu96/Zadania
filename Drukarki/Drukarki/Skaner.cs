using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drukarki
{
    internal class Skaner: Urządzenie, ISkanowanie
    {
        private int SzybkoscSkanowania;

        public Skaner(string model, string marka, int szybkoscSkanowania) : base(model, marka)
        {
            SzybkoscSkanowania = szybkoscSkanowania;
        }

        public string Skanuj()
        {
            return "Skaner rozpoczyna skanowanie";
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
