using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacjenciLinq
{
    internal class Pacjent
    {
        private string imie;
        private string nazwisko;
        private long pesel;
        private string numUbuzpieczenia;
        private int wiek;

        public Pacjent(string imie, string nazwisko, long pesel, string numUbuzpieczenia, int wiek)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Pesel = pesel;
            this.NumUbuzpieczenia = numUbuzpieczenia;
            this.Wiek = wiek;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public long Pesel { get => pesel; set => pesel = value; }
        public string NumUbuzpieczenia { get => numUbuzpieczenia; set => numUbuzpieczenia = value; }
        public int Wiek { get => wiek; set => wiek = value; }
    }
}
