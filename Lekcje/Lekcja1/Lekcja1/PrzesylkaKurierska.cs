using System;
using System.Collections.Generic;
using System.Text;

namespace Lekcja1
{
    class PrzesylkaKurierska : Paczka
    {
        private DateTime dataDostarczenia;

        public PrzesylkaKurierska(double waga, int wysokosc, string adresat, DateTime dataDostarczenia) : base(waga, wysokosc, adresat)
        {
            this.dataDostarczenia = dataDostarczenia;
        }

        public override double Cena() => base.Cena() + (dataDostarczenia - DateTime.Now).Days * 1.5;
    }
}