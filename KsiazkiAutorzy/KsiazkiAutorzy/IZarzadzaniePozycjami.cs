using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkiAutorzy
{
    internal interface IZarzadzaniePozycjami
    {

        public Pozycja ZnajdzPozycjePoTytule(string tytul);

        public Pozycja ZnajdzPozycjePoId(int id);

        public void WypiszWszystkiePozycje();
    }
}
