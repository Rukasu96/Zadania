using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja9
{
    internal class Baza<T> : IEnumerable<T> where T : IComparable<T>
    {
        private T[] array;
        private int count;

        public Baza()
        {
            array = new T[10];
            count = 0;
        }

        public void Add(T element)
        {
            if(count < array.Length)
            {
                array[count++] = element;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < count; i++)
            {
                yield return array[i];
            }
        }

        public void Sort()
        {
            for(int i = 0; i < count - 1; i++)
            {
                for(int j = 0; j < count - 1 - i; j++)
                {
                    if (array[j].CompareTo(array[j+1]) > 0)
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
        }

        public void Sort2(IComparer<T> comparer)
        {
            var list = array.Where(x => x != null).ToList();
            list.Sort(comparer);
            array = list.ToArray();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            array.Take(count).ToList().ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
