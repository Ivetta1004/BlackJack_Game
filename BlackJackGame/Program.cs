using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{

    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                string restart = string.Empty;
                PlayerUser user = new PlayerUser();
                PlayerComputer computer = new PlayerComputer();
                Comparison comparison = new Comparison();
                int userVictory = 0;
                int computerVictory = 0;

                do
                {
                    Console.Clear();
                    Random rnd = new Random();
                    const int computerStep = 1;
                    const int userStep = 2;

                    int firstStep = rnd.Next(computerStep, 3);      // who receives first cards

                    if (firstStep == computerStep)         // computer makes first step
                    {
                        Console.WriteLine("Computer receives first cards.");

                        computer.FirstGameComputer(rnd);
                        user.FirstGameUser(rnd);
                        
                    }

                    if (firstStep == userStep)       // user makes first step
                    {
                        Console.WriteLine("You receive first cards.");

                        user.FirstGameUser(rnd);
                        computer.FirstGameComputer(rnd);
                        
                    }

                    Console.WriteLine();
                    Console.WriteLine("Computer and you have 2 cards.");
                    Console.WriteLine();

                    while (true)
                    {
                        if (firstStep == computerStep)          // if computer made first step
                        {
                            if (computer.ComputerPoints == 21)
                            {
                                Console.WriteLine($"Computer won! It has {computer.ComputerPoints} points.");
                                computerVictory++;
                                break;

                            }

                            else if (computer.ComputerPoints == 22)
                            {
                                Console.WriteLine("Computer won! It has two Aces.");
                                computerVictory++;
                                break;
                            }
                            computer.GameComputer(rnd);

                        }

                        if (firstStep == userStep)               // if user made first step
                        {
                            if (user.UserPoints == 21)
                            {
                                Console.WriteLine($"You won! You have {user.UserPoints} points.");
                                userVictory++;
                                break;

                            }
                            else if (user.UserPoints == 22)
                            {
                                Console.WriteLine("You won! You have two Aces.");
                                userVictory++;
                                break;

                            }

                        }

                        if (computer.ComputerPoints == 22)
                        {
                            Console.WriteLine("Computer won! It has two Aces.");
                            computerVictory++;
                            break;
                        }

                        Console.WriteLine("Please, choose: hit or stay?");
                        string answer = Console.ReadLine();

                        if (answer == "hit" || answer == "h")
                        {

                            user.GameUser(rnd);

                            computer.GameComputer(rnd);

                            if (user.UserPoints > 21)
                            {
                                comparison.ComparisonPoints(user.UserPoints, computer.ComputerPoints);
                                break;

                            }

                            if (user.UserPoints == 21)
                            {
                                comparison.ComparisonPoints(user.UserPoints, computer.ComputerPoints);
                                break;

                            }

                        }
                        if (answer == "stay" || answer == "s")
                        {
                            comparison.ComparisonPoints(user.UserPoints, computer.ComputerPoints);
                            break;
                        }

                    }

                    Console.Write("Do you want to start new game? (yes/no) ");
                    restart = Console.ReadLine();

                } while (restart == "yes" || restart == "y");

                if (restart == "no" || restart == "n")
                {
                    userVictory += comparison.UserVictories;    // if user don't want to restart, we calculate victories
                    computerVictory += comparison.ComputerVictories;
                    Console.WriteLine($"You won {userVictory} times.");
                    Console.WriteLine($"Computer won {computerVictory} times.");
                }

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }


    }


}



