using System;

namespace PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pound = decimal.Parse(Console.ReadLine());
            var dollar = pound * 1.31m;

            Console.WriteLine($"{dollar:f3}");
        }
    }
}
