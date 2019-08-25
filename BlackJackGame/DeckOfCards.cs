using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public struct DeckOfCards
    {
        public Card[] CreateDeck()
        {
            Card[] cards = new Card[36];
            int i = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 2; y <= 11; y++)
                {
                    if (y != 5)
                    {
                        cards[i] = (new Card { Suit = (Suit)x, Face = (Face)y });
                        i++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return cards;
        }
        public Card[] Shuffle(Random rnd)
        {
            Card[] cards = CreateDeck();
            for (int i = cards.Length - 1; i >= 0; i--)
            {
                int j = rnd.Next(cards.Length);
                Card temp = cards[j];
                cards[j] = cards[i];
                cards[i] = temp;
            }
            return cards;
        }
    }
}

