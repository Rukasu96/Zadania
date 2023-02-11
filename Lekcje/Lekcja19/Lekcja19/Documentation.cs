using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja19
{
    internal class Documentation
    {
        public void CreateClassDocs(Type t)
        {
            Attribute[] attrs = Attribute.GetCustomAttributes(t);
            if(!attrs.Any(x => x is AuthorAttribute))
            {
                throw new Exception("Author attribute not exists in argument class");
            }
            if (!attrs.Any(x => x is DescriptionAttribute))
            {
                throw new Exception("Description attribute not exists in argument class");
            }

            Console.WriteLine("Klasa: " + t.Name);
            foreach(Attribute attr in attrs)
            {
                if(attr is AuthorAttribute author)
                {
                    Console.WriteLine($"Zmiana {author.VersionName} by {author.AuthorName}");
                }
            }

            Console.WriteLine("Opis: ");
            foreach (Attribute attr in attrs)
            {
                if(attr is DescriptionAttribute desc)
                {
                    Console.WriteLine(desc.Description);
                }
            }
        }
    }
}
