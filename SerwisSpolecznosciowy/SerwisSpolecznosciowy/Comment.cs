using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisSpolecznosciowy
{
    internal class Comment : Wpis
    {
        private Post post;
        public int Id { get => id; set => id = value; }
        public User User { get => user; set => user = value; }
        public Post Post { get => post; set => post = value; }

        public Comment(DateTime data, string tekst, User user, Post post) : base(data, tekst)
        {
            User = user;
            Post = post;
        }

        public override string ToString()
        {
            return $"{User} Komentuje:\n{tekst}";
        }
    }
}
