using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja19
{
    public class Queue<T>
    {
        private T[] values;
        private int count = 0;

        public Queue(int size)
        {
            values = new T[size];
        }

        public void Enqueue(T value)
        {
            values[count++] = value;
        }

        public T Dequeue()
        {
            if(count > 0)
            {
                T element = values[0];
                ShiftArray();
                return element;
            }

            throw new Exception("Kolejka jest pusta");
        }

        private void ShiftArray()
        {
            for(int i = 1; i < count; i++)
            {
                values[i - 1] = values[i];
            }
        }
    }
}
