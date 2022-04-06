using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var ballance = double.Parse(Console.ReadLine());
            var gamePrice = 0.0;
            var gameSum = 0.0;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${gameSum:f2}. Remaining: ${ballance:f2}");
                    break;
                }

                switch (input)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                        break;
                }

                if (gamePrice > ballance)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                else
                {
                    ballance -= gamePrice;
                    gameSum += gamePrice;

                    Console.WriteLine($"Bought {input}");
                }
            }
        }
    }
}
