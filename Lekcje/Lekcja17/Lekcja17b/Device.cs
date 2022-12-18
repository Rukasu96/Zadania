using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17b
{
    internal class Device
    {
        private int temp = 18;
        private State state;
        private bool on = true;

        public int Temp => temp;
        public bool IsOn => on;

        public Device()
        {
            state = new MenuState(this);
        }

        public void TempUp()
        {
            temp++;
        }

        public void TempDown()
        {
            temp--;
        }

        public void SetState(State s)
        {
            state = s;
        }

        public void PowerOff()
        {
            on = false;
        }

        public void ShowDisplay()
        {
            state.ShowDisplay();
        }

        public void ClickUp()
        {
            state.ClickUp();
        }

        public void ClickDown()
        {
            state.ClickDown();
        }

        public void ClickBack()
        {
            state.ClickBack();
        }
    }
}
