using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja19
{
    [Serializable]
    [Author("Wiki", VersionName = "1.0")]
    [Description(Description = "Klasa przechowujaca dane odnosnie promocji gry")]
    internal class GameData
    {
        public string Title { get; set; }

        [Range(0, 100000)]
        public double Price { get; set; }

        [Range(0, 10000)]
        public double SalePrice { get; set; }
    }
}
