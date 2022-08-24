using System;
using System.Collections.Generic;
using System.Text;

namespace Lekcja1
{
    class Kontener : Paczka
    {
        private bool czyOtwarty;

        public bool CzyOtwarty { get => czyOtwarty; set => czyOtwarty = value; }

        public Kontener(string adresat) : base(300, 100, adresat)
        {
        }

        public override double Cena() => 1000;


    }
}
