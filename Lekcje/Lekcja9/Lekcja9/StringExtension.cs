using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja9
{
    internal static class StringExtension
    {
        public static string RemoveCharacters(this string text, params string[] characters)
        {
            foreach (var ch in characters)
            {
                text = text.Replace(ch, "");
            }
            return text;
        }
    }
}
