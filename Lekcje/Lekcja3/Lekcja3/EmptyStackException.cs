using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja3
{
    internal class EmptyStackException : Exception
    {
        public EmptyStackException() : base("Stack is empty")
        {

        }
    }
}
