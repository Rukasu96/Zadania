using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisSpolecznosciowy
{
    internal class Post : Wpis
    {
        public int Id { get => id; set => id = value; }
        public string Tekst { get => tekst; set => tekst = value; }
        public User User { get => user; set => user = value; }
        public List<Comment> Comments { get; set; }

        public Post(DateTime data, string tekst, User user) : base(data, tekst)
        {
            Comments = new List<Comment>();
            this.tekst = tekst;
            this.user = user;
        }

        public override string ToString()
        {
            return $"{User} Dodał post!\n{Tekst}";
        }


    }
}
