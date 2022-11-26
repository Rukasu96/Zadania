using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lekcja15
{
    public class JSON : IFile
    {
        public void Save(string filename, Kurs[] kursy)
        {
            string json = JsonSerializer.Serialize(kursy);
            File.WriteAllText(filename + ".json", json);
        }
    }
}
