using System;

namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            GetVowelsCount(input);
        }

        static void GetVowelsCount(string input)
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        counter++;
                        break;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
