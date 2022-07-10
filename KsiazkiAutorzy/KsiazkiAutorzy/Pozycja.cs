using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkiAutorzy
{
    abstract class Pozycja
    {
        public string Tytul;
        public int Id;
        public string Wydawnictwo;
        public int RokWydania;

        public Pozycja()
        {

        }

        public Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
        {
            Tytul = tytul;
            Id = id;
            Wydawnictwo = wydawnictwo;
            RokWydania = rokWydania;
        }

        public virtual void WypiszInfo()
        {
            Console.WriteLine($"Tutył: {Tytul}\nID: {Id}\nWydawnictwo: {Wydawnictwo}\nRok Wydania: {RokWydania}");
        }
    }
}
