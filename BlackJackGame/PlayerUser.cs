using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public struct PlayerUser
    {

        DeckOfCards deck;

        public int UserPoints;

        public void FirstGameUser(Random rnd)
        {

            int firstCard = rnd.Next(deck.Points.Length);
            int secondCard = rnd.Next(deck.Points.Length);

            Console.WriteLine($"You receive {deck.Cards[firstCard]} and {deck.Cards[secondCard]}. Current points: {deck.Points[firstCard] + deck.Points[secondCard]}.");

            UserPoints = deck.Points[firstCard] + deck.Points[secondCard];
            
            
        }

        public void GameUser(Random rnd)
        {

            int ifAce = 10;
            int ace = deck.Points[0];
            int card = rnd.Next(deck.Points.Length);
                       
            if (deck.Points[card] == ace && UserPoints > ifAce)
            {
                UserPoints = UserPoints - ifAce;        // if we have Ace when on hand 11 points or more, he will be cost 1 point

            }

            UserPoints += deck.Points[card];

            Console.WriteLine($"You receive {deck.Cards[card]}. Current points: {UserPoints}.");
            
        }

    }




}



