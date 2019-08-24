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
                CalculateResults result = new CalculateResults();
                Random rnd = new Random();
                DeckOfCards deck = new DeckOfCards();
                DeckOfCards[] cards = deck.CreateDeck();
                DeckOfCards[] card = deck.Shuffle(rnd, cards);
                do
                {
                    Console.Clear();
                    const int computerStep = 1;
                    const int userStep = 2;
                    int firstStep = rnd.Next(computerStep, 3);      
                    if (firstStep == computerStep)         
                    {
                        Console.WriteLine("Computer receives first cards.");
                        computer.FirstGameComputer(rnd, card);
                        user.FirstGameUser(rnd, card);
                    }
                    if (firstStep == userStep)       
                    {
                        Console.WriteLine("You receive first cards.");
                        user.FirstGameUser(rnd, card);
                        computer.FirstGameComputer(rnd, card);
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
                            computer.GameComputer(rnd, card);
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
                            user.GameUser(rnd, card);
                            computer.GameComputer(rnd, card);
                            if (user.UserPoints >= 21)
                            {
                                result.ComparisonPoints(user.UserPoints, computer.ComputerPoints);
                                break;
                            }
                        }
                        if (answer == "stay" || answer == "s")
                        {
                            result.ComparisonPoints(user.UserPoints, computer.ComputerPoints);
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



