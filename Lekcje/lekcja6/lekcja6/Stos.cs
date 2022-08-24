using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja6
{
    internal class Stos : IEnumerable<int>
    {
        private int[] array = new int[10];
        private int count = 0;

        public void Add(int number)
        {
            array[count++] = number;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for(int i = 0; i < count; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
