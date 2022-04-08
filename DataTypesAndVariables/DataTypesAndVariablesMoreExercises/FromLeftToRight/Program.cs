using System;

namespace FromLeftToRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string numbers = Console.ReadLine();
                int middle = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    char letters = numbers[j];

                    if (letters == 32)
                    {
                        middle = j;
                    }
                }

                int firstSum = 0;
                int secondSum = 0;
                string firstNumString = "";
                string secondNumString = "";

                for (int num1 = 0; num1 < middle; num1++)
                {
                    firstNumString += numbers[num1];

                    if (numbers[num1] == 45)
                    {
                        continue;
                    }

                    int digits = int.Parse(numbers[num1].ToString());
                    firstSum += digits;
                }

                for (int num2 = middle + 1; num2 < numbers.Length; num2++)
                {
                    secondNumString += numbers[num2];

                    if (numbers[num2] == 45)
                    {
                        continue;
                    }

                    int digits = int.Parse(numbers[num2].ToString());
                    secondSum += digits;
                }

                long firstNumInt = long.Parse(firstNumString);
                long secondNumInt = long.Parse(secondNumString);
                
                if (firstNumInt > secondNumInt)
                {
                    Console.WriteLine(firstSum);
                }
                else
                {
                    Console.WriteLine(secondSum);
                }

            }
        }
    }
}
