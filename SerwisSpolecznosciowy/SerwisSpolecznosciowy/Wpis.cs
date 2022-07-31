using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisSpolecznosciowy
{
    internal class Wpis
    {
        protected int id;
        protected DateTime data;
        protected string tekst;
        protected User user;

        public Wpis(DateTime data, string tekst)
        {
            this.data = data;
            this.tekst = tekst;
        }
    }
}
