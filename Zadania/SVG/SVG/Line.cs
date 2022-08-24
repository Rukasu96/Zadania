using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG
{
    class Line : ElementSVG
    {
        public Line(int x1, int y1, int x2, int y2, string stroke): base(x1, y1, stroke)
        {
           if(x2 > width)
           {
                x2 = 100;
           } 
           if(y2 > height)
           {
                y2 = 100;
           }

            X2 = x2;
            Y2 = y2;
        }


        private int X2;
        private int Y2;


        public override string Draw()
        {
            return $"<line x1=\"{cx}\" y1=\"{cy}\" x2=\"{X2}\" y2=\"{Y2}\" stroke=\"{color}\" />";
        }


    }
}
