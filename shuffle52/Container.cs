using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace shuffle52
{
    class Container
    {
        private List<List<Card>> _cardGroups;   //Each component list represents a group (or pile) of cards at this location.

        private List<Player> _visibleTo;

        private Point _position;

        public List<List<Card>> CardGroups { get { return _cardGroups; } }

        public List<Player> VisibleTo { get { return _visibleTo; } }

        public Point Position { get { return _position; } set { _position = value; } }

        public Container(Point position)
        {
            _cardGroups = new List<List<Card>>();
            _visibleTo = new List<Player>();
            _position = position;
        }
    }
}
