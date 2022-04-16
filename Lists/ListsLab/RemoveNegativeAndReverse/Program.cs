using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativeAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers = RemoveNegativeNumbers(numbers);

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numbers.Reverse();
                Console.WriteLine(String.Join(" ", numbers));
            }
        }

        static List<int> RemoveNegativeNumbers(List<int> numbers)
        {
            List<int> newNumbers = new List<int>();
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    newNumbers.Add(numbers[i]);
                }
            }

            return newNumbers;
        }
    }
}
