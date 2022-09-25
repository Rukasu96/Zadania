using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja9
{
    internal class User : IComparable<User>
    {
        private string name;
        private string email;

        public User(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public int CompareTo(User? other)
        {
            if(name == other.name)
            {
                return email.CompareTo(other.email);
            }
            return name.CompareTo(other.name);
        }

        public override string ToString()
        {
            return $"{name} ({email})";
        }

        public class ByNameLength : IComparer<User>
        {
            public int Compare(User? x, User? y)
            {
                return y.name.Length.CompareTo(x.name.Length);
            }
        }
    }
}
