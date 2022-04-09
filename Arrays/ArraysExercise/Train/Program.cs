using System;
using System.Linq;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] passengers = new int[input];
            int totalPassengers = 0;

            for (int i = 0; i < input; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                totalPassengers += passengers[i];
            }

            Console.WriteLine(String.Join(" ",passengers));
            Console.WriteLine(totalPassengers);
        }
    }
}
