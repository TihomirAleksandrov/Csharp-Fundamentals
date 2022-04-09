using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int biggestCounter = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        counter++;
                        biggestCounter = counter;

                    }
                    else
                    {
                        break;
                    }
                }
                else if (i == 0 && numbers[i] == numbers[i + 1])
                {
                    counter++;

                    if (biggestCounter <= counter)
                    {
                        biggestCounter = counter;
                    }
                }
                else if (numbers[i] == numbers[i+1] || numbers[i] == numbers[i-1])
                {
                    counter++;

                    if (biggestCounter <= counter)
                    {
                        biggestCounter = counter;
                    }
                }
                else
                {
                    counter = 0;
                }
            }

            Console.WriteLine(biggestCounter);

            int[] sequence = new int [biggestCounter];
            int sequenceIndex = 0;
            counter = 0;
            biggestCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        counter++;
                        biggestCounter = counter;
                        sequence[sequenceIndex] = numbers[i];
                        sequenceIndex++;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (i == 0 && numbers[i] == numbers[i + 1])
                {
                    counter++;

                    if (biggestCounter <= counter)
                    {
                        biggestCounter = counter;
                    }
                }
                else if (numbers[i] == numbers[i + 1] || numbers[i] == numbers[i - 1])
                {
                    counter++;

                    if (biggestCounter <= counter)
                    {
                        biggestCounter = counter;
                        sequence[sequenceIndex] = numbers[i];
                        sequenceIndex++;
                    }
                }
                else
                {
                    counter = 0;
                }
            }

            Console.WriteLine(String.Join(" ", sequence));
        }
    }
}
