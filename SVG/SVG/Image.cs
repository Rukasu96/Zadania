using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG
{
    class Image
    {

        public Image()
        {
            Shapes = new List<ElementSVG>();
            Svg = new ElementSVG();
        }

        private List<ElementSVG> Shapes;
        private ElementSVG Svg;
        public void Add(ElementSVG shape)
        {
            Shapes.Add(shape);
        }

        public void Show()
        {
            Console.WriteLine($"<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"{Svg.width}\" height=\"{Svg.height}\" version=\"1.1\" >");
            foreach (ElementSVG shape in Shapes)
            {
                Console.WriteLine(shape.Draw());
            }
            Console.WriteLine("</svg>");
        }


    }
}
