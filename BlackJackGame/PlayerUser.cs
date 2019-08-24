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
        public void FirstGameUser(Random rnd, DeckOfCards[] card)
        {
            int firstCard = rnd.Next(card.Length);
            int secondCard = rnd.Next(card.Length);
            UserPoints = (int)card[firstCard].Card + (int)card[secondCard].Card;
            Console.WriteLine($"You receive {card[firstCard].Card} {card[firstCard].Suit} and {card[secondCard].Card} {card[secondCard].Suit}. " +
                 $"Current points: {UserPoints}.");
        }
        public void GameUser(Random rnd, DeckOfCards[] cards)
        {
            int card = rnd.Next(cards.Length);
            UserPoints += (int)cards[card].Card;
            Console.WriteLine($"You receive {cards[card].Card} {cards[card].Suit}. Current points: {UserPoints}.");
        }
    }
}



