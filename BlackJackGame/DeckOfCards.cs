using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public enum Card
    {
        Jack = 2,
        Lady = 3,
        King = 4,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Ace = 11
    }

    public enum Suit
    {
        Heart,
        Diamond,
        Spade,
        Club
    }

    public struct DeckOfCards
    {
        public Suit Suit;
        public Card Card;
        public DeckOfCards[] CreateDeck()
        {
            DeckOfCards[] deck = new DeckOfCards[36];
            int i = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 2; y <= 11; y++)
                {
                    if (y != 5)
                    {
                        deck[i] = (new DeckOfCards() { Suit = (Suit)x, Card = (Card)y });
                        i++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return deck;
        }
        public DeckOfCards[] Shuffle(Random rnd, DeckOfCards[] cards)
        {
            for (int i = cards.Length - 1; i >= 0; i--)
            {
                int j = rnd.Next(cards.Length);
                DeckOfCards temp = cards[j];
                cards[j] = cards[i];
                cards[i] = temp;
            }
            return cards;
        }
    }
}
