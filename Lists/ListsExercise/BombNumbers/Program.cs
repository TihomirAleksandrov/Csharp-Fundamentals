using System;
using System.Linq;
using System.Collections.Generic;

namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] bombNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();

            numbers = BombNumbers(numbers, bombNumber[0], Math.Abs(bombNumber[1]));

            SumNumbers(numbers);
        }

        static List<int> BombNumbers(List<int> numbers, int bombNumber, int power)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int targetLeft = i - power;
                    int targetRight = i + power;

                    for (int right = i; right <= targetRight; right++)
                    {
                        if (i >= numbers.Count)
                        {
                            break;
                        }
                        else
                        {
                            numbers.RemoveAt(i);
                        }
                    }

                    for (int left = i - 1; left >= targetLeft; left--)
                    {
                        if (left < 0)
                        {
                            break;
                        }
                        else
                        {
                            numbers.RemoveAt(left);
                        }
                    }
                   
                    i = 0;
                }
            }
            
            return numbers;
        }

        static void SumNumbers(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0;i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
