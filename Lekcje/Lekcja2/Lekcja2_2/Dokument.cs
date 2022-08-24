using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2_2
{
    internal class Dokument : ICSV, IExcel
    {
        void ICSV.Write()
        {
            Console.WriteLine("1;this is csv doc;1234"); 
        }

        void IExcel.Write()
        {
            Console.WriteLine("This is spreadsheet");
        }
    }
}
