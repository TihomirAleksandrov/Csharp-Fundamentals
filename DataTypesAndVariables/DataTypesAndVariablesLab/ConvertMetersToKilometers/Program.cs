using System;

namespace ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meters = int.Parse(Console.ReadLine());
            var kilometers = meters / 1000.0m;
            
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
