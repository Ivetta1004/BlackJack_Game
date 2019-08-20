using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public struct DeckOfCards
    {
        public string[] Cards
        {
            get { return new string[] { "Ace", "Ten", "Nine", "Eight", "Seven", "Six", "King", "Lady", "Jack" }; }
        }

        public int[] Points
        {
            get { return new int[] { 11, 10, 9, 8, 7, 6, 4, 3, 2 }; }

        }


    }
}
