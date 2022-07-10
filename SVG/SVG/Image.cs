using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG
{
    class Image
    {
        private int Width;
        private int Height;

        public Image()
        {
            Shapes = new List<ElementSVG>();
            Width = 300;
            Height = 300;
        }

        private List<ElementSVG> Shapes;
        public void Add(ElementSVG shape)
        {
            Shapes.Add(shape);
        }

        public void Show()
        {
            Console.WriteLine($"<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"{width}\" height=\"{height}\" version=\"1.1\" >");
            foreach (ElementSVG shape in Shapes)
            {
                Console.WriteLine(shape.Draw());
            }
            Console.WriteLine("</svg>");
        }


    }
}
