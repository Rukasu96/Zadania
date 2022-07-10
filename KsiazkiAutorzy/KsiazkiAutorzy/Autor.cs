using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkiAutorzy
{
    internal class Autor
    {
        private string imie;
        private string nazwisko;

        public string Imie 
        { 
            get { return imie; }
            set { imie = value; }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public Autor()
        {

        }

        public Autor(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

    }
}
