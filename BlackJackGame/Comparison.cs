using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public struct Comparison
    {
        public int UserVictories;
        public int ComputerVictories;


        public int ComparisonPoints(int userPoints, int computerPoints)
        {
                      
            if (userPoints == 21 && computerPoints > userPoints || userPoints == 21 && computerPoints < userPoints)
            {
                Console.WriteLine($"You won! You have 21 points. Computer has {computerPoints} points.");
                
                return UserVictories++;
            }

            if (computerPoints == 21 && userPoints > computerPoints || computerPoints == 21 && userPoints < computerPoints)
            {
                Console.WriteLine("Computer won! It has 21 points.");
                return ComputerVictories++;
            }

            if (computerPoints >= 22 && userPoints < computerPoints)
            {
                Console.WriteLine($"You won! You have {userPoints} points. Computer has {computerPoints} points.");
                return UserVictories++;
            }

            if (userPoints >= 22 && computerPoints < userPoints)
            {
                Console.WriteLine($"Computer: {computerPoints} points.");
                Console.WriteLine($"User: {userPoints} points.");
                Console.WriteLine("Computer won. You lost.");
                return ComputerVictories++;
            }

            if (computerPoints == userPoints)           // if they have the same amount of points, nobody won't have a victory
            {
                Console.WriteLine($"Computer: {computerPoints} points.");
                Console.WriteLine($"User: {userPoints} points.");
                Console.WriteLine("You and the computer have the same amount of points.");
            }

            if (computerPoints < 22 && userPoints < 22 && computerPoints > userPoints)
            {
                Console.WriteLine($"Computer: {computerPoints} points.");
                Console.WriteLine($"User: {userPoints} points.");
                Console.WriteLine("Computer won. You lost.");
                return ComputerVictories++;
            }

            if (computerPoints < 22 && userPoints < 22 && userPoints > computerPoints)
            {
                Console.WriteLine($"Computer: {computerPoints} points.");
                Console.WriteLine($"User: {userPoints} points.");
                Console.WriteLine("You won!");
                return UserVictories++;
            }

            return 0;

        }



    }
}
