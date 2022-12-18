using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17b
{
    internal class MenuState : State
    {
        public MenuState(Device device) : base(device)
        {
        }

        public override void ClickBack()
        {
            device.PowerOff();
        }

        public override void ClickDown()
        {
            device.SetState(new InfoState(device));
        }

        public override void ClickUp()
        {
            device.SetState(new TempState(device));
        }

        public override void ShowDisplay()
        {
            Console.WriteLine("< Power Off /\\ Set temp \\/ Info Temp: " + device.Temp + " *C");
        }
    }
}
