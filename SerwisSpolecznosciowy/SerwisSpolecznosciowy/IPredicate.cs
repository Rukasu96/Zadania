using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisSpolecznosciowy
{
    internal interface IPredicate
    {

        public void FindFirstPost(Predicate<Post> predicate); 
    }
}
