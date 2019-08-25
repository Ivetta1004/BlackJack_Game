using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public struct PlayerUser
    {
        public int UserPoints;
        public void FirstGameUser(Card[] card, int counter)
        {
            int firstCard = --counter;
            int secondCard = --counter;
            UserPoints = (int)card[firstCard].Face + (int)card[secondCard].Face;
            Console.WriteLine($"You receive {card[firstCard].Face} {card[firstCard].Suit} and {card[secondCard].Face} {card[secondCard].Suit}. " +
                 $"Current points: {UserPoints}.");
        }
        public void GameUser(Card[] cards, int counter)
        {
            int card = --counter;
            UserPoints += (int)cards[card].Face;
            Console.WriteLine($"You receive {cards[card].Face} {cards[card].Suit}. Current points: {UserPoints}.");
        }
    }
}



