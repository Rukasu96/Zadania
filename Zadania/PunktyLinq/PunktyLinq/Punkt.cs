using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunktyLinq
{
    internal class Punkt
    {
        private int posX;
        private int posY;
        private Random rand;

        public Punkt()
        {
            rand = new Random();
            this.PosX = rand.Next(-20, 20);
            this.PosY = rand.Next(-20, 20);
        }

        public int PosX { get => posX; set => posX = value; }
        public int PosY { get => posY; set => posY = value; }
    }
}
