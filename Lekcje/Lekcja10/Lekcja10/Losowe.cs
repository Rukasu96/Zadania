using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja10
{
    internal class Losowe : IEnumerable<int>
    {
        private int min;
        private int max;
        private Random random;

        public Losowe(int min, int max)
        {
            this.min = min;
            this.max = max;
            random = new Random();
        }

        public IEnumerator<int> GetEnumerator()
        {
            yield return 10;
            for(int i = 0; i < 10; i++)
            {
                yield return random.Next(min, max);
            }
            yield return 3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
