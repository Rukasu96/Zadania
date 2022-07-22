using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkiAutorzy
{
    internal class Biblioteka:IZarzadzaniePozycjami
    {
        private string adres;
        private List<Katalog> katalogi = new List<Katalog>();
        private List<Bibliotekarz> bibliotekarze = new List<Bibliotekarz>();

        public Biblioteka()
        {

        }

        public Biblioteka(string adres_)
        {
            adres = adres_;
        }

        public void DodajBibliotekarza(Bibliotekarz bibliotekarz)
        {
            bibliotekarze.Add(bibliotekarz);
        }

        public void WypiszBibliotekarzy()
        {
            foreach(Bibliotekarz bibliotekarz in bibliotekarze)
            {
                Console.WriteLine(bibliotekarz.WypiszBibliotekarza());
            }
        }

        public void DodajKatalog(Katalog katalog)
        {
            katalogi.Add(katalog);
        }

        public void DodajPozycje(Pozycja p, string dzialTematyczny)
        {
            foreach(Katalog katalog in katalogi)
            {
                if(katalog.Dzialtematyczny == dzialTematyczny)
                {
                    katalog.DodajPozycje(p);
                }
            }
        }

        public void WypiszWszystkiePozycje()
        {
           // for (int i = 0; i < katalogi.Count; i++)
           // {
           //    Console.WriteLine($"Katalog {i+1}\n Dzial tematyczny: {katalogi[i].Dzialtematyczny}");
            //}

            foreach(Katalog katalog in katalogi)
            {
                katalog.WypiszWszystkiePozycje();
            }
        }

        public Pozycja ZnajdzPozycjePoId(int id)
        {
            foreach (Katalog katalog in katalogi)
            {
                return katalog.ZnajdzPozycjePoId(id);
            }
            return null;
        }

        public Pozycja ZnajdzPozycjePoTytule(string tytul)
        {
            foreach (Katalog katalog in katalogi)
            {
                return katalog.ZnajdzPozycjePoTytule(tytul);
            }
            return null;
        }

        public Pozycja ZnajdzPozycje(Predicate predicate)
        {
            foreach (Katalog katalog in katalogi)
            {
                return katalog.ZnajdzPozycje(predicate);
            }
            return null;
        }

        public Pozycja ZnajdzPozycje2(Func<Pozycja, bool> predicate)
        {
            foreach (Katalog katalog in katalogi)
            {
                return katalog.ZnajdzPozycje2(predicate);
            }
            return null;
        }
    }
}
