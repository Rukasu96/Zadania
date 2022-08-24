using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkiAutorzy
{
    abstract class Osoba
    {
        protected string imie;
        protected string nazwisko;

        public string Imie { get => imie; }
        public string Nazwisko { get => nazwisko; }

        public Osoba()
        {

        }

        public Osoba(string imie_, string nazwisko_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
        }

    }
}
