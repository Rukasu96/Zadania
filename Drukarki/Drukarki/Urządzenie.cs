using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drukarki
{
    internal class Urządzenie
    {
        private string Marka;
        private string Model; 

        public Urządzenie(string model, string marka)
        {
            Model = model;
            Marka = marka;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
