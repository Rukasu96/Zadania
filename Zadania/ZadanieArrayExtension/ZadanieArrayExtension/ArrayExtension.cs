﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieArrayExtension
{
    internal class ArrayExtension
    {
        
        static public void ForEach(int[] tab, Action<int[],int> action)
        {
            for(int i = 0; i < tab.Length; i++)
            {
                action(tab, i);
            }
        }

    }
}
