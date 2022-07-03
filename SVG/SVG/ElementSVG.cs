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
            Width = 300;
            Height = 300;

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

            Width = 300;
            Height = 300;
        }


        private int Width;
        private int Height;
        private int Cx;
        private int Cy;
        private string Color;

        public int width { get => Width;}
        public int height { get => Height;}

        public int cx { get => Cx; }
        public int cy { get => Cy; }
        public string color { get => Color; }

        public virtual string Draw()
        {
            return $"Rysuj kształt";
        }



    }
}
