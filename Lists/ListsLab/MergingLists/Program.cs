using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> mergedNumbers = GetMergedLists(numbers1, numbers2);

            mergedNumbers = CheckForExtraNums(numbers1, numbers2, mergedNumbers);

            Console.WriteLine(String.Join(" ", mergedNumbers));
        }

        static List<int> CheckForExtraNums(List<int> numbers1, List<int> numbers2, List<int> mergedNumbers)
        {
            if (numbers1.Count < numbers2.Count)
            {
                for (int i = numbers1.Count; i < numbers2.Count; i++)
                {
                    mergedNumbers.Add(numbers2[i]);
                }
            }
            else if (numbers1.Count > numbers2.Count)
            {
                for (int i = numbers2.Count; i < numbers1.Count; i++)
                {
                    mergedNumbers.Add(numbers1[i]);
                }
            }

            return mergedNumbers;
        }

        static List<int> GetMergedLists(List<int> numbers1, List<int> numbers2)
        {
            int smallerCount = Math.Min(numbers1.Count, numbers2.Count);

            int index1 = 0;
            int index2 = 0;

            List<int> mergedNumbers = new List<int>();

            for (int i = 0; i < smallerCount * 2; i++)
            {
                if (i % 2 == 0)
                {
                    mergedNumbers.Add(numbers1[index1]);
                    index1++;
                }
                else
                {
                    mergedNumbers.Add(numbers2[index2]);
                    index2++;
                }
            }

            return mergedNumbers;
        }
    }
}
