using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG
{
    class ElementSVG
    {
        public ElementSVG()
        {
        }

        public ElementSVG(int cx, int cy, string color)
        {
            if (cx <= 0 && cx >= width)
            {
                Cx = 50;
            }
            if (cy <= 0 && cy >= width)
            {
                Cy = 50;
            }
            

            Cx = cx;
            Cy = cy;
            Color = color;
        }


        private int Cx;
        private int Cy;
        private string Color;

        public int cx { get => Cx; }
        public int cy { get => Cy; }
        public string color { get => Color; }

        public virtual string Draw()
        {
            return $"Rysuj kształt";
        }



    }
}
