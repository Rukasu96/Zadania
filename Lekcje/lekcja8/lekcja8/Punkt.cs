using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja8
{
    internal struct Punkt : IEquatable<Punkt>
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public bool Equals(Punkt other)
        {
            return x == other.x && y == other.y;
        }
    }
}
