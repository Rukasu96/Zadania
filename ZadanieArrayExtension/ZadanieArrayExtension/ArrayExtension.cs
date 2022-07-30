using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieArrayExtension
{
    internal class ArrayExtension
    {
        
        static public void ForEach(int[] tab, int index, Action<int[],int> action)
        {
            for(int i = 0; i < index; i++)
            {
                action(tab, i);
            }
        }

    }
}
