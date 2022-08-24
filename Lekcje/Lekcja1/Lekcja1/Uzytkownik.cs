using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lekcja1
{
    class Uzytkownik
    {
        private List<Paczka> paczki;

        public double Cena => paczki.Sum(p => p.Cena());
        //{
        //    get
        //    {
        //        double suma = 0;
        //        foreach (var item in paczki)
        //        {
        //            suma += item.Cena();
        //        }
        //        return suma;
        //    }
        //}

        public Uzytkownik()
        {
            paczki = new List<Paczka>();
        }

        public void DodajPaczke(Paczka p)
        {
            paczki.Add(p);
        }

        public override string ToString()
        {
            return $"Cena do zaplaty: {Cena}";
        }
    }
}
