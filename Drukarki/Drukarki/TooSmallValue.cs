using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drukarki
{
    internal class TooSmallValue : Exception
    {
        public TooSmallValue() : base("Wartość musi być większa od zera")
        {

        }

    }
}
