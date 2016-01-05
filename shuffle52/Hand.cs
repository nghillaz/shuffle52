using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace shuffle52
{
    class Hand : Container
    {
        private Player _player;

        public Player OwningPlayer { get { return _player; } }

        public Hand(Point position, Player player) : base(position)
        {
            _player = player;
        }
    }
}
