using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuffle52
{
    class Deck
    {
        private Card[] _cards;

        private List<Player> _associatedPlayers;    //At the end of the game, these players are associated with this deck (for scoring purposes).

        #region getters
        public Card[] Cards { get { return _cards; } }

        public List<Player> AssociatedPlayers { get { return _associatedPlayers; } }
        #endregion

        public Deck()
        {
            _cards = new Card[54];

            //Initialize all the cards in the deck.
            int index = 0;
            for(int suit = 0; suit < 4; suit++)
            {
                for(int number = 0; number < 13; number++)
                {
                    _cards[index] = new Card(this, number, suit);
                    index++;
                }
            }

            //Add the jokers.
            for (int i = 0; i < 2; i++)
            {
                _cards[index] = new Card(this, 14, -1);
                index++;
            }

            _associatedPlayers = new List<Player>();
        }
    }
}
