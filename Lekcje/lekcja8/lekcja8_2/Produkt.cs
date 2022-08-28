using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja8_2
{
    internal record ProductBase
    {

    }

    internal record Produkt(string Marka, double Cena, string Nazwa) : ProductBase
    {
        public double CenaBrutto => Cena * 1.23;
    }
}
