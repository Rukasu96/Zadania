using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG
{
    class Ellipse : ElementSVG
    {

        public Ellipse(int cx, int cy, int rx, int ry, string fillColor, string strokeColor) : base(cx, cy, fillColor)
        {
            if(rx > width)
            {
                rx = 50;
            }
            if(ry > height)
            {
                ry = 50;
            }

            Rx = rx;
            Ry = ry;
            StrokeColor = strokeColor;
        }

        private int Rx;
        private int Ry;
        private string StrokeColor;

        public override string Draw()
        {
            return $"<ellipse cx=\"{cx}\" cy=\"{cy}\" rx=\"{Rx}\" ry=\"{Ry}\" \n style=\"fill:{color};stroke:{StrokeColor};stroke-width:2\" />";
        }

    }
}
