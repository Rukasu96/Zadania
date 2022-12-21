using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18d
{
    internal class GameProxy : IGame
    {
        private Game game;

        public GameProxy(string username, string password)
        {
            if(username == "admin" && password == "admin")
            {
                game = new Game();
            }
        }

        public void Play()
        {
            if(game != null)
            {
                game.Play();
            }
            else
            {
                Console.WriteLine("Brak uprawnien, niepoprawne logowanie");
            }
        }
    }
}
