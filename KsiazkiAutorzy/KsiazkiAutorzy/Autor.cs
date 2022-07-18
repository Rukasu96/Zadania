using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkiAutorzy
{
    internal class Autor:Osoba
    {
        private string narodowosc;


        public Autor()
        {

        }

        public Autor(string imie_, string nazwisko_, string narodowosc_):base(imie_, nazwisko_)
        {
            narodowosc = narodowosc_;
        }

    }
}
