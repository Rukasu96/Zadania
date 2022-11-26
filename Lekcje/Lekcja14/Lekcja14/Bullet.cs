using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja14
{
    public class Bullet
    {
        private int x;
        private int y;
        private BulletType type;
        private bool inUse;

        public Bullet(BulletType type)
        {
            this.x = 0;
            this.y = 0;
            this.type = type;
            inUse = true;
        }

        public bool InUse { get => inUse; }

        public void Move()
        {
            for(int i = 0; i < 30; i += type.Speed)
            {
                Console.Write(type.Symbol);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Stop");
            inUse = false;
        }

        public void Reset()
        {
            inUse = true;
            x = 0;
            y = 0;
        }
    }
}
