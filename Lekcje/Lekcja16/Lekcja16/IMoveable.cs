using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja16
{
    internal interface IMoveable
    {
        void Move(int x, int y);
        void Jump();
    }
}
