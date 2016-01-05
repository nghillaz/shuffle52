using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuffle52
{
    class Player
    {
        private Team _team;

        private List<Deck> _associatedDecks;

        private string _name;

        #region accessors
        public Team Team { get { return _team; } set { _team = value; } }

        public List<Deck> AssociatedDecks { get { return _associatedDecks; } }

        public string Name { get { return _name; } }
        #endregion

        #region constructors
        public Player(string name) : this(null, name){}

        public Player(Team team, string name)
        {
            _team = team;
            _associatedDecks = new List<Deck>();
            _name = name;
        }
        #endregion
    }
}
