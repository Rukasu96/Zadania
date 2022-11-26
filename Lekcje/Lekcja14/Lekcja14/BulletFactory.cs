using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja14
{
    public class BulletFactory
    {
        private BulletType bulletType;
        private List<Bullet> bullets;

        public BulletFactory(BulletType bulletType)
        {
            this.bulletType = bulletType;
            bullets = new List<Bullet>();
        }

        public Bullet Create()
        {
            Bullet find = bullets.FirstOrDefault(x => !x.InUse);
            if(find != null)
            {
                find.Reset();
            }
            else
            {
                Console.WriteLine("New bullet created");
                find = new Bullet(bulletType);
                bullets.Add(find);
            }
            return find;
        }
    }
}
