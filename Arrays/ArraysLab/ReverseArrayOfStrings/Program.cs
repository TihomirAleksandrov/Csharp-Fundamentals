using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            Array.Reverse(words);

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
