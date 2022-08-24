using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkiAutorzy
{
    internal class Ksiazka : Pozycja
    {
        private int liczbaStron;
        private List<Autor> Autorzy = new List<Autor>();
        public Ksiazka()
        {

        }

        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int LiczbaStron) : base(tytul, id, wydawnictwo, rokWydania)
        {
            liczbaStron = LiczbaStron;
        }

        public void DodajAutora(Autor autor)
        {
            Autorzy.Add(autor);
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine($"Liczba Stron: {liczbaStron}");
            foreach(Autor autor in Autorzy)
            {
                Console.WriteLine($"Imie: {autor.Imie}\nNazwisko: {autor.Nazwisko}");
            }
        }
    }
}
