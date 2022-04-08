using System;

namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int availableYield = int.Parse(Console.ReadLine());
            int counter = 0;
            int totalYield = 0;

            while (availableYield >= 100)
            {
                totalYield += availableYield;
                totalYield -= 26;
                availableYield -= 10;
                counter++;
            }

            if (totalYield - 26 >= 0)
            {
                totalYield -= 26;
            }
            else
            {
                totalYield = 0;
            }

            Console.WriteLine(counter);
            Console.WriteLine(totalYield);
        }
    }
}
