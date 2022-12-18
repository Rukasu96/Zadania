using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17b
{
    internal class TempState : State
    {
        public TempState(Device device) : base(device)
        {
        }

        public override void ClickBack()
        {
            device.SetState(new MenuState(device));
        }

        public override void ClickDown()
        {
            device.TempDown();
        }

        public override void ClickUp()
        {
            device.TempUp();
        }

        public override void ShowDisplay()
        {
            Console.WriteLine("< Back /\\ Temp Up \\/ Temp Down Temp: " + device.Temp);
        }
    }
}
