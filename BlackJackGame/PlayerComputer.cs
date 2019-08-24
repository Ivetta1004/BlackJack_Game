using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public struct PlayerComputer
    {
        public int ComputerPoints;
        public void FirstGameComputer(Random rnd, DeckOfCards[] card)
        {
            int firstCard = rnd.Next(card.Length);
            int secondCard = rnd.Next(card.Length);
            ComputerPoints = (int)card[firstCard].Card + (int)card[secondCard].Card;           
        }
        public void GameComputer(Random rnd, DeckOfCards[] cards)
        {
            int card = rnd.Next(cards.Length);
            if (ComputerPoints <= 17)
            {
                ComputerPoints += (int)cards[card].Card;
            }          
        }
    }
}
