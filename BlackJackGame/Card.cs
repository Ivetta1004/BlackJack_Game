using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public enum Face
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
    public struct Card
    {
       public Suit Suit;
       public Face Face;       
    }
}
