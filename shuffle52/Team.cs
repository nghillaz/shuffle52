using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuffle52
{
    class Team
    {
        private List<Player> _players;

        private string _name;

        public List<Player> Players { get { return _players; } }

        public string Name { get { return _name; } }

        public Team(string name)
        {
            _name = name;
            _players = new List<Player>();
        }
    }
}
