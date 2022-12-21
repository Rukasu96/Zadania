using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18c
{
    internal class Game
    {
        private GameState state;

        public GameState State
        {
            get { return state; }
            set { state = value; }
        }

        public Memento SaveState()
        {
            return new Memento(state.Clone() as GameState);
        }

        public void LoadState(Memento memento)
        {
            state = memento.GetState();
        }

        public void Fight()
        {
            Random rand = new Random();
            state.Health += rand.Next(-10, 5);
            Console.WriteLine($"Aktualny stan HP: {state.Health}");
        }

        public bool IsAlive()
        {
            return state.Health > 0;
        }

        public override string ToString()
        {
            return $"HP {state.Health} Mana: {state.Mana} Lvl: {state.Level}";
        }
    }
}
