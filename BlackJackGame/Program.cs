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
                int userVictory = 0;
                int computerVictory = 0;
                PlayerUser user = new PlayerUser();
                PlayerComputer computer = new PlayerComputer();
                ResultsCalculator result = new ResultsCalculator();
                Random rnd = new Random();
                DeckOfCards deck = new DeckOfCards();
                do
                {
                    Console.Clear();
                    Card[] card = deck.Shuffle(rnd);
                    int counter = card.Length;
                    const int computerStep = 1;
                    const int userStep = 2;
                    int firstStep = rnd.Next(computerStep, 3);
                    if (firstStep == computerStep)
                    {
                        Console.WriteLine("Computer receives first cards.");
                        computer.FirstGameComputer(card, counter);
                        counter -= 2;
                        user.FirstGameUser(card, counter);
                        counter -= 2;
                    }
                    if (firstStep == userStep)
                    {
                        Console.WriteLine("You receive first cards.");
                        user.FirstGameUser(card, counter);
                        counter -= 2;
                        computer.FirstGameComputer(card, counter);
                        counter -= 2;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Computer and you have 2 cards.");
                    Console.WriteLine();
                    while (true)
                    {
                        if (firstStep == computerStep)
                        {
                            if (computer.ComputerPoints == 21 || computer.ComputerPoints == 22)
                            {
                                Console.WriteLine($"Computer won! It has {computer.ComputerPoints} points.");
                                computerVictory++;
                                break;
                            }
                            computer.GameComputer(card, counter);
                            --counter;
                        }
                        if (firstStep == userStep)
                        {
                            if (user.UserPoints == 21 || user.UserPoints == 22)
                            {
                                Console.WriteLine($"You won! You have {user.UserPoints} points.");
                                userVictory++;
                                break;
                            }
                        }
                        Console.WriteLine("Please, choose: hit or stay?");
                        string answer = Console.ReadLine();
                        if (answer == "hit" || answer == "h")
                        {
                            user.GameUser(card, counter);
                            --counter;
                            computer.GameComputer(card, counter);
                            --counter;
                            if (user.UserPoints >= 21)
                            {
                                result.CheckPoints(user.UserPoints, computer.ComputerPoints);
                                break;
                            }
                        }
                        if (answer == "stay" || answer == "s")
                        {
                            result.CheckPoints(user.UserPoints, computer.ComputerPoints);
                            break;
                        }
                    }
                    Console.Write("Do you want to start new game? (yes/no) ");
                    restart = Console.ReadLine();
                } while (restart == "yes" || restart == "y");
                if (restart == "no" || restart == "n")
                {
                    userVictory += result.UserVictories;
                    computerVictory += result.ComputerVictories;
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



