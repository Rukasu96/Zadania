using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja19
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        private string authorName;

        public string VersionName { get; set; }
        public string AuthorName { get => authorName; }

        public AuthorAttribute(string authorName)
        {
            this.authorName = authorName;
        }
    }
}
