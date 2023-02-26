using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja19
{
    internal class Validator
    {
        public Validator() { }

        public void Validate(object o)
        {
            PropertyInfo[] properties = o.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Attribute attr = property.GetCustomAttribute(typeof(RangeAttribute));
                if (attr is RangeAttribute range)
                {
                    double value;
                    object? val = property.GetValue(o);
                    if (val is int)
                    {
                        value = (int)val;
                    }
                    else
                    {
                        value = (double)val;
                    }
                    if (value < range.From || value > range.To)
                    {
                        Console.WriteLine($"Wartość {value} w property {property.Name} jest poza zakresem {range.From} {range.To}");
                    }
                }
            }
        }
    }
}
