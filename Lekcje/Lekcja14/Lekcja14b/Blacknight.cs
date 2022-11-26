using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja14b
{
    [Serializable]
    internal class Blacknight : Enemy
    {
        private string name;
        private int attack;
        private int[] stats;

        public Blacknight(string name, int attack)
        {
            this.name = name;
            this.attack = attack;
            this.stats = new[] { 1, 5, 8};
        }

        public override Enemy Clone()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;

                return (Enemy)formatter.Deserialize(ms);
            }
        }

        public override string ToString()
        {
            return $"Blacknight name={name} attack={attack}";
        }

        public void SetAttack(int newAttack)
        {
            attack = newAttack;
            stats[1]--;
        }
    }
}
