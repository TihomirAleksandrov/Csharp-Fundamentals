using System;

namespace CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int battlesCounter = 0;
            bool flag = true;

            string input = Console.ReadLine();

            while (input != "End of battle")
            {
                int distance = int.Parse(input);
                
                if (distance <= energy)
                {
                    battlesCounter++;
                    energy -= distance;

                    if (battlesCounter % 3 == 0)
                    {
                        energy += battlesCounter;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesCounter} won battles and {energy} energy");
                    flag = false;
                    break;
                }
                
                input = Console.ReadLine();
            }

            if (flag)
            {
                Console.WriteLine($"Won battles: {battlesCounter}. Energy left: {energy}");
            }
        }
    }
}
