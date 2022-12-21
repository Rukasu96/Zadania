using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18
{
    internal class ComputerBuilder
    {
        private Computer computer;

        public ComputerBuilder()
        {
            Reset();
        }

        public ComputerBuilder WithProcessor(string processor)
        {
            computer.Processor = processor;
            return this;
        }

        public ComputerBuilder WithGraphicsCard(string graphicsCard)
        {
            computer.GraphicsCard = graphicsCard;
            return this;
        }

        public ComputerBuilder WithRAM(int ram)
        {
            computer.RAM = ram;
            return this;
        }

        public ComputerBuilder WithStorage(int storage)
        {
            computer.Storage = storage;
            return this;
        }

        public Computer Build()
        {
            return computer;
        }

        public void Reset()
        {
            computer = new Computer();
        }
    }
}
