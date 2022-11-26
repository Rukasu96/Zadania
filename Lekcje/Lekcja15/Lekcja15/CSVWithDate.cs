using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja15
{

    public class CSVWithDate : CSV
    {
        public override void Save(string filename, Kurs[] kursy)
        {
            Delimeter = ",";
            base.Save(filename, kursy);
            string text = File.ReadAllText(filename + ".json");
            File.WriteAllText(filename + ".json", DateTime.Now + "\n" + text);
            Delimeter = ";";
        }
    }
}
