using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkiAutorzy
{
    internal class Bibliotekarz:Osoba
    {
        private string dataZatrudnienia;
        private double wynagrodzenie;

        public Bibliotekarz()
        {

        }

        public Bibliotekarz(string imie_, string nazwisko_, string dataZatrudnienia_, double wynagrodzenie_):base(imie_,nazwisko_)
        {
            dataZatrudnienia = dataZatrudnienia_;
            wynagrodzenie = wynagrodzenie_;
        }

        public string WypiszBibliotekarza()
        {
            return $"{imie} {nazwisko}\n Data zatrudnienia: {dataZatrudnienia}\n Wynagrodzenie: {wynagrodzenie}";
        }
    }
}
