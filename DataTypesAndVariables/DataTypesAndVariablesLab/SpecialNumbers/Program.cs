using System;

namespace SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte num = byte.Parse(Console.ReadLine());
            
            for (int i = 1; i <= num; i++)
            {
                byte firstDigit = (byte)(i % 10);
                byte secondDigit = (byte)(i / 10);
                byte sum = (byte)(firstDigit + secondDigit);
                bool flag = (sum == 5 || sum == 7 || sum == 11);

                Console.WriteLine($"{i} -> {flag}");
            }
        }
    }
}
