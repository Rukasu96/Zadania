using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG
{
    class Circle : ElementSVG
    {
        public Circle(int cx, int cy, int r, string color) : base(cx, cy, color)
        {
            if(r <= 0 && (r > width || r> height))
            {
                R = 30;
            }

            R = r;
        }

        private int R;

        public override string Draw()
        {
            return $"<circle cx=\"{cx}\" cy=\"{cy}\" r=\"{R}\" fill=\"{color}\" />";
        }
    }
}
