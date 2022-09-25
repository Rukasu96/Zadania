using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja9
{
    internal static class ListExtension
    {
        public static string GetString<T>(this IEnumerable<T> elements)
        {
            StringBuilder sb = new StringBuilder();
            foreach (T element in elements)
            {
                sb.Append(element.ToString()).Append(" ");
            }
            return sb.ToString();
        }
    }
}

//SQL Server Express 2019
//SQL Server Management Studio