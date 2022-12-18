using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17
{
    internal interface IEnemy
    {
        int HP { get; set; }
        void Attack();
    }
}
