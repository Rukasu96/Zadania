using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja16c
{
    [Serializable]
    internal class Player : ICloneable
    {
        private string name;
        private int[] position;

        public string Name { get => name; set => name = value; }

        public Player(string name)
        {
            this.Name = name;
            this.position = new int[]  {0 , 0 };
        }

        public object Clone()
        {
            using(MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, this);
                ms.Seek(0, SeekOrigin.Begin);
                return bf.Deserialize(ms);
            }
        }

        public void Move(int x, int y)
        {
            position[0] = x;
            position[1] = y;
        }

        public override string? ToString()
        {
            return $"{name} x={position[0]} y={position[1]}";
        }
    }
}
