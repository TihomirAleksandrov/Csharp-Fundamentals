using System;
using System.Linq;
using System.Collections.Generic;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers = GetTop5Numbers(numbers);

            if (numbers.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }

        static List<int> GetTop5Numbers(List<int> numbers)
        {
            double averageValue = GetAverageValue(numbers);
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageValue)
                {
                    result.Add(numbers[i]);
                }
            }

            result.Sort();
            result.Reverse();

            if (result.Count > 5)
            {
                while (result.Count > 5)
                {
                    result.RemoveAt(5);
                }
            }

            return result;
        }

        static double GetAverageValue(List<int> numbers)
        {
            int totalSum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                totalSum += numbers[i];
            }

            double averageValue = (double)totalSum / numbers.Count;

            return averageValue;
        }
    }
}
