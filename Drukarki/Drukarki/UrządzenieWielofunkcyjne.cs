using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drukarki
{
    internal class UrządzenieWielofunkcyjne:Drukarka, IDrukowanie, ISkanowanie
    {
        private string RodzajPolaczenia;

        public UrządzenieWielofunkcyjne(string model, string marka,int iloscTuszu, string rodzajPolaczenia):base(model, marka, iloscTuszu)
        {
            RodzajPolaczenia = rodzajPolaczenia;
        }

        public string Skanuj()
        {
            return "Urządzenie zaczyna skanowanie";
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
