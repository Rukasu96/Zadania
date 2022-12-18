using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja16
{
    internal class Tower : IAttacker
    {
        public void Attack(ICharacter character)
        {
            Console.WriteLine("Atakuje!!!!");
        }
    }
}
