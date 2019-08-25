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
        public void FirstGameComputer(Card[] cards, int counter)
        {
            int firstCard = --counter;
            int secondCard = --counter;
            ComputerPoints = (int)cards[firstCard].Face + (int)cards[secondCard].Face;
        }
        public void GameComputer(Card[] cards, int counter)
        {
            if (ComputerPoints <= 17)
            {
                int card = --counter;
                ComputerPoints += (int)cards[card].Face;
            }
        }
    }
}
