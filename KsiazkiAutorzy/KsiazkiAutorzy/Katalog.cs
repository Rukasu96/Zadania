using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkiAutorzy
{
    internal class Katalog:IZarzadzaniePozycjami
    {

        private string dzialtematyczny;
        private List<Pozycja> pozycje = new List<Pozycja>();

        public string Dzialtematyczny { get => dzialtematyczny;}

        public Katalog()
        {

        }

        public Katalog(string dzialTematyczny_)
        {
            dzialtematyczny = dzialTematyczny_;
        }

        public void DodajPozycje(Pozycja pozycja)
        {
            pozycje.Add(pozycja);
        }

        public void WypiszWszystkiePozycje()
        {
            foreach(Pozycja pozycja in pozycje)
            {
                pozycja.WypiszInfo();
                Console.WriteLine();
            }
        }

        public Pozycja ZnajdzPozycjePoId(int id)
        {
            foreach (Pozycja pozycja in pozycje)
            {
                if (pozycja.Id == id)
                {
                    return pozycja;
                }
            }
            return null;
        }

        public Pozycja ZnajdzPozycjePoTytule(string tytul)
        {
            foreach (Pozycja pozycja in pozycje)
            {
                if (pozycja.Tytul == tytul)
                {
                    return pozycja;
                }
            }
            return null;
        }
    }
}
