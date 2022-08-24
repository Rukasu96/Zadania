using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkiAutorzy
{
    internal class Czasopismo: Pozycja
    {
        private int Numer;

        public Czasopismo()
        {

        }

        public Czasopismo(string tytul, int id, string wydawnictwo, int rokWydania, int numer) : base(tytul, id, wydawnictwo, rokWydania)
        {
            Numer = numer;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine($"Numer magazynu: {Numer}");
        }
    }
}
