using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja16c
{
    internal class PlayerFactory
    {
        private Dictionary<string, Player> players = new Dictionary<string, Player>();

        public void Add(string key, Player p)
        {
            players[key] = p;
        }

        public Player GetNewPlayer(string key)
        {
            return players[key].Clone() as Player;
        }
    }
}
