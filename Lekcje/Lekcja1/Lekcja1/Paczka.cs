using System;
using System.Collections.Generic;
using System.Text;

namespace Lekcja1
{
    class Paczka
    {
        private double waga;
        private int wysokosc;
        private string adresat;
        private static int licznik;

        static Paczka() //konstrutkor statyczny, wywoluje sie przed pierwszym uzyciem klasy
        {
            licznik = 1;
        }

        public double Waga {
            get
            {
                return waga;
            }
            set
            {
                if(value > 0)
                {
                    waga = value;
                }
            }
        }

        public double WagaCalkowita => Waga + 0.2; //sam getter

        public int Id { get; private set; }

        public string Adresat { get => adresat; }

        public int Wysokosc { 
            set
            {
                if(value > 0)
                {
                    wysokosc = value;
                }
            }
        }

        public Paczka()
        {
            Waga = 1;
            wysokosc = 1;
            adresat = "brak";
            Id = licznik++;
        }

        public Paczka(double waga, int wysokosc, string adresat)
        {
            if(waga < 0)
            {
                waga = 1;
            }
            if(wysokosc < 0)
            {
                wysokosc = 1;
            }
            this.Waga = waga;
            this.wysokosc = wysokosc;
            this.adresat = adresat;
            Id = licznik++;
        }

        public void SetWaga(double waga)
        {
            if(waga > 0)
            {
                this.Waga = waga;
            }
        }

        public virtual double Cena() => Waga * 0.5 + wysokosc;

        public override string ToString()
        {
            return $"Paczka waga: {waga}, cena: {Cena()}$";
        }
    }
}
