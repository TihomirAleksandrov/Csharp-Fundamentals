using System;

namespace LowerToUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            string output = "";

            if (letter >= 65 && letter <= 90)
            {
                output = "upper-case";
            }
            else if (letter >= 97 && letter <= 122)
            {
                output = "lower-case";
            }

            Console.WriteLine(output);
        }
    }
}
