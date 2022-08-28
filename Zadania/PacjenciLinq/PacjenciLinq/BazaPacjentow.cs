using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacjenciLinq
{
    internal class BazaPacjentow
    {
        private List<Pacjent> pacjenci;

        public BazaPacjentow()
        {
            pacjenci = new List<Pacjent>();
        }

        public void DodajPacjenta(Pacjent pacjent)
        {
            pacjenci.Add(pacjent);
        }

        public void UsunPacjenta(Pacjent pacjent)
        {
            pacjenci.Remove(pacjent);
        }

        public List<Pacjent> StarsiNiż(int wiek)
        {
            return pacjenci.Where(x => x.Wiek > wiek).ToList();
        }

        public Pacjent Znajdz(string imie, string nazwisko)
        {
            var znalezionyPacjent = pacjenci.First(x => x.Imie == imie && x.Nazwisko == nazwisko);
            return znalezionyPacjent;
        }

        public int PoliczNieUbezpieczonych()
        {
            var nieUbezpieczoni = pacjenci.Count(x => x.NumUbuzpieczenia == null || x.NumUbuzpieczenia == string.Empty);
            return nieUbezpieczoni;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            pacjenci.ForEach(x => sb.AppendLine($"{x.Imie} {x.Nazwisko}"));
            return sb.ToString();
        }
    }
}
