using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja3
{
    internal class Stos
    {
        private int[] liczby;
        private int aktualnyRozmiar;

        public Stos(int maxRozmiar)
        {
            if(maxRozmiar <= 0)
            {
                throw new ArgumentException("Negative size value");
            }
            liczby = new int[maxRozmiar];
            aktualnyRozmiar = 0;
        }

        public void Push(int liczba)
        {
            if(aktualnyRozmiar >= liczby.Length)
            {
                throw new OverflowException("Stack is full");
            }

            liczby[aktualnyRozmiar++] = liczba;
        }

        public int Pop()
        {
            if(aktualnyRozmiar == 0)
            {
                throw new EmptyStackException();
            }

            return liczby[--aktualnyRozmiar];
        }
    }
}
