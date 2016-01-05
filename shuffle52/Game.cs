using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuffle52
{
    class Game
    {
        private List<Team> _teams;

        private List<Container> _containers;

        private int _gameType;

        #region accessors
        public List<Team> Teams { get { return _teams; } }

        public List<Container> Containers { get { return _containers; } }

        public int GameType { get { return _gameType; } set { _gameType = value; } }
        #endregion

        public Game(int gameType)
        {
            _teams = new List<Team>();
            _containers = new List<Container>();
            _gameType = gameType;
        }

        public Game() : this(0) { }
    }
}
