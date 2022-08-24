using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkiAutorzy
{
    delegate bool Predicate(Pozycja p);

    internal interface IZarzadzaniePozycjami
    {
        public Pozycja ZnajdzPozycje(Predicate predicate);
        public Pozycja ZnajdzPozycje2(Func<Pozycja, bool> predicate);

        public Pozycja ZnajdzPozycjePoTytule(string tytul);

        public Pozycja ZnajdzPozycjePoId(int id);

        public void WypiszWszystkiePozycje();
    }
}
