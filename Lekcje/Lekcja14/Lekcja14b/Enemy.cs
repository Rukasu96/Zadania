using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja14b
{
    [Serializable]
    internal abstract class Enemy
    {
        public abstract Enemy Clone();
    }
}
