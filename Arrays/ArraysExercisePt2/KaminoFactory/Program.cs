using System;
using System.Linq;

namespace KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            int bestSequencePosition = 0;
            int sequenceCounter = 0;
            int bestCounter = 0;
            int[] bestSequence = new int[sequenceLength];
            int bestSum = 0;
            int leftmostIndex = int.MaxValue;
            string command = Console.ReadLine();

            while (command != "Clone them!")
            {
                int[] dnaSample = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int prevNum = dnaSample[0];
                int counter = 1;
                int biggestCounter = 0;
                int sum = dnaSample[0];
                int startIndex = 0;
                bool flag = false;
                
                sequenceCounter++;



                for (int i = 1; i < sequenceLength; i++)
                {

                    if (dnaSample[i] != 1 && dnaSample[i] != 0)
                    {
                        break;
                    }
                    else if (dnaSample[i] == prevNum && dnaSample[i] == 1)
                    {
                        counter++;
                        if (flag)
                        {
                            startIndex = i-1;
                            flag = false;
                        }
                    }
                    else
                    {
                        prevNum = dnaSample[i];
                        counter = 1;
                        flag = true;
                    }

                    if (counter > biggestCounter)
                    {
                        biggestCounter = counter;
                    }

                    sum += dnaSample[i];
                }

                if (biggestCounter == 1)
                {
                    for (int i = 0; i < dnaSample.Length; i++)
                    {
                        if (dnaSample[i] == 1)
                        {
                            startIndex = i;
                            break;
                        }
                    }
                }

                if (biggestCounter > bestCounter)
                {

                    bestSum = sum;
                    bestCounter = biggestCounter;
                    bestSequence = dnaSample;
                    bestSequencePosition = sequenceCounter;
                    leftmostIndex = startIndex;
                }
                else if (biggestCounter == bestCounter)
                {
                    if (startIndex < leftmostIndex)
                    {
                        bestSum = sum;
                        bestCounter = biggestCounter;
                        bestSequence = dnaSample;
                        bestSequencePosition = sequenceCounter;
                    }
                    else if (startIndex == leftmostIndex)
                    {
                        if (sum > bestSum)
                        {
                            bestSum = sum;
                            bestCounter = biggestCounter;
                            bestSequence = dnaSample;
                            bestSequencePosition = sequenceCounter;
                        }
                    }
                }

                if (sum == 0)
                {
                    bestSequencePosition = 1;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequencePosition} with sum: {bestSum}.");
            Console.WriteLine(String.Join(" ", bestSequence));
        }
    }
}
