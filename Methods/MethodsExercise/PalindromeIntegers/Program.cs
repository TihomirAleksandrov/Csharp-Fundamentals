using System;
using System.Linq;

namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                CheckPalindromeNumber(input);

                input = Console.ReadLine();
            }
        }

        static void CheckPalindromeNumber(string input)
        {
            int middle = input.Length / 2;
            int lastDigit = input.Length - 1;
            bool isPalindrome = true;

            if (middle % 2 == 0)
            {
                for (int i = 0; i < middle - 1; i++)
                {
                    if (input[i] != input[lastDigit - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i <= middle; i++)
                {
                    if (input[i] != input[lastDigit - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isPalindrome);
        }
    }
}
