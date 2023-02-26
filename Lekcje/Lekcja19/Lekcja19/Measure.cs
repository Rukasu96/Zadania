using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja19
{
    internal class Measure
    {
        [Range(10, 50)]
        public int Temperature { get; set; }
    }
}
