using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja5
{
    public class Game
    {
        public string title { get; set; }
        public string salePrice { get; set; }
        public string normalPrice { get; set; }
        public string steamRatingText { get; set; }

        public int releaseDate { get; set; }

        public DateTime ReleaseDate => DateTime.FromFileTimeUtc(releaseDate);

        public float SalePrice => float.Parse(salePrice, CultureInfo.InvariantCulture);

        public override string ToString()
        {
            return $"{title,-40} {salePrice,5}, {normalPrice,5} {steamRatingText,20} {ReleaseDate}";
        }
    }
}
