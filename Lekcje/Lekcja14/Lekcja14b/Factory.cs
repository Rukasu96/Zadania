using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja14b
{
    internal class Spawn
    {
        private Dictionary<string, Enemy> enemies;

        public Spawn()
        {
            enemies = new Dictionary<string, Enemy>();
        }

        public void Add(string key, Enemy enemy)
        {
            enemies[key] = enemy;
        }

        public Enemy Create(string key)
        {
            if(!enemies.ContainsKey(key))
            {
                throw new Exception("Key error");
            }

            return enemies[key].Clone();
        }
    }
}
