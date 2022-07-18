using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkiAutorzy
{
    abstract class Pozycja
    {
        private string tytul;
        private int id;
        private string wydawnictwo;
        protected int RokWydania;

        public string Tytul { get => tytul; set => tytul = value; }
        public string Wydawnictwo { get => wydawnictwo; set => wydawnictwo = value; }

        public int Id { get => Id; set => id = value; }

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
