using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2
{
    internal class Druid : Player
    {
        public Druid(string name) : base(name)
        {

        }

        public void LeczSie()
        {
            Hp += 10;
        }

        public override string? ToString()
        {
            return "Druid " + base.ToString();
        }
    }
}
