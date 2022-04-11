using System;

namespace MethodsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CheckNumber(number);
        }

        static void CheckNumber(int number)
        {
            string numType = string.Empty;

            if (number > 0)
            {
                numType = "positive";
            }
            else if (number < 0)
            {
                numType = "negative";
            }
            else
            {
                numType = "zero";
            }

            Console.WriteLine($"The number {number} is {numType}. ");
        }
    }
}
