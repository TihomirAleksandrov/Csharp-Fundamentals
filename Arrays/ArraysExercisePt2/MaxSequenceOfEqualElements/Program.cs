using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int prevNum = numbers[0];
            int counter = 1;
            int bestSequence = 0;
            int bestNumber = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == prevNum)
                {
                    counter++;
                }
                else
                {
                    prevNum = numbers[i];
                    counter = 1;
                }

                if (counter > bestSequence)
                {
                    bestSequence = counter;
                    bestNumber = numbers[i];
                }
            }

            for (int i = 0; i < bestSequence; i++)
            {
                Console.Write($"{bestNumber} ");
            }
        }
    }
}
