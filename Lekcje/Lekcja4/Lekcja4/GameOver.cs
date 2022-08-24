using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja4
{
    internal class GameOver : ISubscriber
    {
        public void Update(int hp)
        {
            if(hp == 0)
            {
                Console.WriteLine("Exit game!");
                Environment.Exit(0);
            }    
        }
    }
}
