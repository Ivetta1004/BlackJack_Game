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
        public int forAceTemp;
        DeckOfCards deck;
       
        public void FirstGameComputer(Random rnd)
        {
                       
           int firstCard = rnd.Next(deck.Points.Length);
           int secondCard = rnd.Next(deck.Points.Length);

          // Console.WriteLine($"Computer receive {deck.Cards[firstCard]} and {deck.Cards[secondCard]}. Current points: {deck.Points[firstCard] + deck.Points[secondCard]}.");

           ComputerPoints = deck.Points[firstCard] + deck.Points[secondCard];
           
            
        }

        public void GameComputer(Random rnd)
        {
            int ifAce = 10;
           
            int card = rnd.Next(deck.Points.Length);

            if (ComputerPoints <= 17)
            {
                                
                if (deck.Points[card] == deck.Points[0] && ComputerPoints > ifAce)
                {
                    ComputerPoints = ComputerPoints - ifAce;      // if we have Ace when on hand 11 points or more, he will be cost 1 point

                }
                ComputerPoints += deck.Points[card];

            }

            
           // Console.WriteLine($"Computer receives {deck.Cards[card]}. Current points: {ComputerPoints}.");
        }

        

    }
}
