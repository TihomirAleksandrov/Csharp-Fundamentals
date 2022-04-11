using System;

namespace MultiplyEvenByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);

            return evenSum * oddSum;
        }

        static int GetSumOfEvenDigits(int numbers)
        {
            int evenSum = 0; 
            
            while (numbers > 0)
            {
                if (numbers % 2 == 0)
                {
                    evenSum += numbers % 10;
                }
               
                numbers /= 10;
            }
            
            return evenSum;
        }

        static int GetSumOfOddDigits(int numbers)
        {
            int oddSum = 0;
            
            while (numbers > 0)
            {
                if (numbers % 2 != 0)
                {
                    oddSum += numbers % 10;
                }

                numbers /= 10;
            }

            return oddSum;
        }
    }
}
