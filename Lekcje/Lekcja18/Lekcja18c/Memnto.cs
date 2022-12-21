using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18c
{
    internal class Memento
    {
        private GameState gameState;

        public Memento(GameState gameState)
        {
            this.gameState = gameState;
        }

        public GameState GetState()
        {
            return gameState;
        }
    }
}
