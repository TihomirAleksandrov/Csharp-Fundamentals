using System;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            long[] numbers = { 1 };

            for (int i = 1; i <= input; i++)
            {
                long[] newNumbers = new long[numbers.Length + 1];
               
                for (int j = 0; j < numbers.Length; j++)
                {
                    newNumbers[j] = numbers[j];
                }

                for (int j = 0; j < i; j++)
                {
                    if (j >= numbers.Length)
                    {
                        newNumbers[j] = numbers[j - 1];
                    }
                    else
                    {
                        if (j == 0)
                        {
                            newNumbers[j] = numbers[j];
                        }
                        else
                        {
                            newNumbers[j] = numbers[j] + numbers[j - 1];
                        }
                    }

                    Console.Write($"{newNumbers[j]} ");
                }
                Console.WriteLine();

                numbers = newNumbers;
            }
        }
    }
}
