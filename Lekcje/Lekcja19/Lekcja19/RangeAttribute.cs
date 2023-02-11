using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja19
{
    public class RangeAttribute : Attribute
    {
        public int From { get; }
        public int To { get; }

        public RangeAttribute(int from, int to)
        {
            From = from;
            To = to;
        }
    }
}
