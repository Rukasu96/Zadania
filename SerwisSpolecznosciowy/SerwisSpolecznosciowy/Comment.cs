﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisSpolecznosciowy
{
    internal class Comment : Wpis
    {
        private Post post;

        public int Id { get; set; }
        public User User { get; set; }
        public Post Post { get; set; }
    }
}
