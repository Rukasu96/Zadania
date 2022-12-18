﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja16
{
    internal class Knight : ICharacter
    {
        public void Attack(ICharacter character)
        {
            Console.WriteLine("Atakuje");
        }

        public void Heal()
        {
            Console.WriteLine("Lecze sie");
        }

        public void Jump()
        {
            Console.WriteLine("Skacze");
        }

        public void Move(int x, int y)
        {
            Console.WriteLine("Przesuwam sie");
        }
    }
}
