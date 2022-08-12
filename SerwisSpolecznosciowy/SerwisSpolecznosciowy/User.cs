using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisSpolecznosciowy
{
    internal class User
    {
        private int id;
        private string email;
        private string login;
        private string password;
        private static int counter = 1;

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public List<Post> numberPosts { get; set; }

        public User(string login, string password, string email)
        {
            this.login = login;
            this.password = password;
            this.email = email;
            numberPosts = new List<Post>();
            id = counter++;
        }

        public override string ToString()
        {
            return $"{login} {password} {id} {email}";
        }
    }
}
