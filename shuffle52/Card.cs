using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuffle52
{
    //This class defines a game card.
    class Card
    {
        private Deck _origin;

        private int _number;
        private int _suit;

        #region getters
        public Deck Origin { get { return _origin; } }

        public int Number { get { return _number; } }
        public int Suit { get { return _suit; } }
        #endregion

        public Card(Deck origin, int number, int suit)
        {
            _origin = origin;

            _number = number;
            _suit = suit;
        }
    }
}
