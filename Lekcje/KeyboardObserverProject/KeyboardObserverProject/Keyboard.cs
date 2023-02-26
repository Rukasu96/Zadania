﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardObserverProject
{
    internal class Keyboard
    {
        public event Action? OnLeft;
        public event Action? OnRight;
        public event Action? OnUp;
        public event Action? OnDown;
        public event Action? OnEnter;

        public void UpdateEvents()
        {
            var input = Console.ReadKey().Key;

            switch (input)
            {
                case ConsoleKey.LeftArrow:
                    OnLeft?.Invoke();
                    break;
                case ConsoleKey.UpArrow:
                    OnUp?.Invoke();
                    break;
                case ConsoleKey.RightArrow:
                    OnRight?.Invoke();
                    break;
                case ConsoleKey.DownArrow:
                    OnDown?.Invoke();
                    break;
                case ConsoleKey.Enter:
                    OnEnter?.Invoke();
                    break;
            }
        }
    }
}
