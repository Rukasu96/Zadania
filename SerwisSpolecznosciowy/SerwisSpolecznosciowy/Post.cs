using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisSpolecznosciowy
{
    internal class Post : Wpis
    {
        private List<Comment> comments;

        public int Id { get; set; }
        public string Tekst { get => tekst; set => tekst = value; }
        public User User { get => user; set => user = value; }


    }
}
