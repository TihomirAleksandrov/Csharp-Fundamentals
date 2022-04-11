using System;

namespace MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string middle = GetMiddleCharacter(input);
            Console.WriteLine(middle);
        }

        static string GetMiddleCharacter(string input)
        {
            int middle = input.Length / 2;
            string middleChar = string.Empty;

            if (input.Length % 2 == 0)
            {
                middleChar += input[middle - 1].ToString();
                middleChar += input[middle].ToString();
            }
            else
            {
                middleChar = input[middle].ToString();
            }

            return middleChar;
        }
    }
}
