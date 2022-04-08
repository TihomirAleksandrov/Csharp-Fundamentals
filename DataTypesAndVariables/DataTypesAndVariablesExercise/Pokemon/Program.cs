using System;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exaustionFactor = int.Parse(Console.ReadLine());
            int counter = 0;
            double remainingPower = power;

            while (remainingPower >= distance)
            {
                remainingPower -= distance;
                counter++;

                if (power / 2 == remainingPower && exaustionFactor != 0)
                {
                    remainingPower /= exaustionFactor;
                }
            }

            Console.WriteLine((int)remainingPower);
            Console.WriteLine(counter);
        }
    }
}
