using System;

namespace SVG
{
    class Program
    {
        static void Main()
        {
            Image o = new Image();

            o.Add(new Circle(50, 50, 44, "red"));
            o.Add(new Ellipse(30, 20, 20, 35, "yellow", "purple"));
            o.Add(new Line(1, 4, 100, 100, "black"));
            o.Show();
        }
    }
}

