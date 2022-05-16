using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playeAgain = true;
            int randomInt;
            string playerInput, CPUInput;
            while (playeAgain)
            {
                int playerScore = 0;
                int cpuScore = 0;
                while (playerScore < 3 && cpuScore < 3)
                {
                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);
                    Console.Write("choose between\n 1: ROCK\n 2: PAPER\n 3: SCISSOR\n  ");
                    playerInput = Console.ReadLine();
                    playerInput = playerInput.ToUpper();

                    switch (randomInt)
                    {
                        case 1:
                            CPUInput = "ROCK";
                            Console.WriteLine("Computer choose ROCK");
                            if (playerInput == "1")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (playerInput == "2")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerScore++;
                            }
                            else if (playerInput == "3")
                            {
                                Console.WriteLine("COMPUTER WINS!!\n\n");
                                cpuScore++;
                            }
                            else
                                Console.WriteLine("Invalid entry!");
                            break;
                        case 2:
                            CPUInput = "PAPER";
                            Console.WriteLine("Computer choose PAPER");
                            if (playerInput == "2")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (playerInput == "3")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerScore++;
                            }
                            else if (playerInput == "1")
                            {
                                Console.WriteLine("COMPUTER WINS!!\n\n");
                                cpuScore++;
                            }
                            else
                                Console.WriteLine("Invalid entry!");
                            break;
                        case 3:
                            CPUInput = "SCISSOR";
                            Console.WriteLine("Computer choose SCISSOR");
                            if (playerInput == "3")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (playerInput == "1")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerScore++;
                            }
                            else if (playerInput == "2")
                            {
                                Console.WriteLine("COMPUTER WINS!!\n\n");
                                cpuScore++;
                            }
                            else
                                Console.WriteLine("Invalid entry!");
                            break;

                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
                    Console.WriteLine("\n\n SCORES: \tPLAYER:\t{0}\tC:\t{1}", playerScore, cpuScore);
                }
                if (playerScore > 3)
                    {
                        Console.WriteLine("PLAYER WON");
                    }
                    else if (cpuScore > 3)
                        Console.WriteLine("COMPUTER WON");
                
                Console.WriteLine("Do you want to play again? (Y/N)");
                string loop = Console.ReadLine();
                loop = loop.ToLower();
                if (loop == "y")
                {
                    playeAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playeAgain = false;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                
            }
        }
    }
}
