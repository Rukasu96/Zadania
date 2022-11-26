using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja15
{
    public class Pilot
    {
        private IOdbiornik tv;

        public Pilot(IOdbiornik tv) //Dependecy Injection - zamiast tworzyc obiekt w klasie to go "wstrzykujemy" przez konstruktor i zapamietujemy
        {
            this.tv = tv;
        }

        public void WlaczPolsat()
        {
            tv.Wlacz();
            tv.UstawKanal(4);
        }

        public void WylaczTv()
        {
            tv.Wylacz();
        }
    }
}
