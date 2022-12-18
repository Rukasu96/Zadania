using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17b
{
    internal class InfoState : State
    {
        public InfoState(Device device) : base(device)
        {
        }

        public override void ClickBack()
        {
            device.SetState(new MenuState(device));
        }

        public override void ClickDown()
        {

        }

        public override void ClickUp()
        {

        }

        public override void ShowDisplay()
        {
            Console.WriteLine("Autor: Ada Kowalska");
        }
    }
}
