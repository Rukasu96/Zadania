using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja14b
{
    internal class RedDevil : Enemy
    {
        private int manna;

        public RedDevil(int manna)
        {
            this.manna = manna;
        }

        public override Enemy Clone()
        {
            return new RedDevil(manna);
        }

        public override string ToString()
        {
            return $"Blacknight manna={manna}";
        }
    }
}
