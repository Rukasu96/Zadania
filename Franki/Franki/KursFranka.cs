using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franki
{
    internal class KursFranka
    {

        private float przelicznik;
        private List<IZainteresowany> zainteresowani;

        public float Przelicznik { get
            {
                return przelicznik;
            }
            set
            {
                przelicznik = value;
                WyslijInfo();
            }
        }

        public KursFranka(float _przelicznik)
        {
            przelicznik = _przelicznik;
            zainteresowani = new List<IZainteresowany>();
        }

        public void DodajZainteresowanego(IZainteresowany zainteresowany)
        {
            zainteresowani.Add(zainteresowany);
        }

        public void WyslijInfo()
        {
            foreach (var zainteresowany in zainteresowani)
            {
                zainteresowany.ZmianaKursu(przelicznik);
            }
        }

    }
}
