using System;
using System.Linq;
using System.Collections.Generic;

namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(string.Join(" ", GetReversedNums(input)));
        }

        static List<int> GetReversedNums(string input)
        {
            List<string> separateInputs = input.Split('|').ToList();

            separateInputs.Reverse();

            List<int> numbers = new List<int>();

            for (int i = 0; i < separateInputs.Count; i++)
            {
                List<int> currNums = separateInputs[i].Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                for (int j = 0; j < currNums.Count; j++)
                {
                    numbers.Add(currNums[j]);
                }
            } 

            return numbers;
        }
    }
}
