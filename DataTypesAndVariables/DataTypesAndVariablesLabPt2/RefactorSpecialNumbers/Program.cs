using System;

namespace RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int num1 = i % 10;
                int num2 = i / 10;
                int sum = num1 + num2;

                bool flag = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {flag}");
            }

        }
    }
}
