using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17
{
    internal interface IBiomeFactory
    {
        IEnemy CreateEnemy();
        IBlock CreateBlock();
        ITree CreateTree();
    }
}
