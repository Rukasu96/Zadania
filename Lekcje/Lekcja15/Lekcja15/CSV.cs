using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja15
{
    public class CSV : IFile
    {
        public string Delimeter { get; set; } = ";";   

        public virtual void Save(string filename, Kurs[] kursy)
        {
            using (StreamWriter sw = new StreamWriter(filename + ".csv"))
            {
                foreach (var kurs in kursy)
                {
                    sw.WriteLine(kurs.Data.ToShortDateString() + Delimeter + kurs.Cena);
                }
            }
        }
    }
}
