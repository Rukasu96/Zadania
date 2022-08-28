using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja8_3
{
    internal class Stos<T>
    {
        private T[] tab;
        private int count;

        public Stos()
        {
            tab = new T[10];
            count = 0;
        }

        public void Push(T element)
        {
            if(count < tab.Length)
            {
                tab[count++] = element;
            }
        }

        //public T Sum()
        //{
        //    T result = default(T);
        //    for(int i = 0; i < count; i++)
        //    {
        //        result = result + tab[i];
        //    }
        //    return result;
        //}

        public T Pop()
        {
            if(count == 0)
            {
                throw new Exception("Empty stack");
            }
            return tab[--count];
        }
    }
}
