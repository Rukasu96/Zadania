using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkiAutorzy
{
    internal class Katalog
    {

        private string Dzialtematyczny;
        private List<Pozycja> Pozycje = new List<Pozycja>();
        public Katalog()
        {

        }

        public Katalog(string dzialTematyczny)
        {
            Dzialtematyczny = dzialTematyczny;
        }

        public void DodajPozycje(Pozycja pozycja)
        {
            Pozycje.Add(pozycja);
        }

        public void WypiszWszystkiePozycje()
        {
            foreach(Pozycja pozycja in Pozycje)
            {
                pozycja.WypiszInfo();
                Console.WriteLine();
            }
        }

        public void ZnajdzPozycje(string Tytul, string Wydawnictwo)
        {
            foreach(Pozycja pozycja in Pozycje)
            {
                if(pozycja.Tytul == Tytul || pozycja.Wydawnictwo == Wydawnictwo)
                {
                    pozycja.WypiszInfo();
                }

            }
        }

    }
}
