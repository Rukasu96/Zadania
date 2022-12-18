using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17b
{
    internal abstract class State
    {
        protected Device device;

        public State(Device device)
        {
            this.device = device;
        }

        public abstract void ShowDisplay();
        public abstract void ClickUp();
        public abstract void ClickDown();
        public abstract void ClickBack();
    }
}
