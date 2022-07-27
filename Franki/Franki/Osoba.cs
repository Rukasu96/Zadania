using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franki
{
    internal class Osoba : IZainteresowany
    {

        private string imie;
        private string nazwisko;
        private float kwota;

        public Osoba(string _imie, string _nazwisko, float _kwota)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            kwota = _kwota;
        }


        public void ZmianaKursu(float kurs)
        {
            Console.WriteLine($"Zmiana wartości franka na {kurs}, aktualna wartość kredytu w zł dla {imie} {nazwisko} to: {kwota * kurs}zł");
        }
    }
}
