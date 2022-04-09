using System;

namespace RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPosition = int.Parse(Console.ReadLine());
            long[] sequence = GetFibonacciSequence(numberPosition);
            long number = sequence[numberPosition];
            Console.WriteLine(number);
        }

        static long[] GetFibonacciSequence (int numberPosition)
        {
            long[] fibonacciSequence = new long[numberPosition + 1];
            fibonacciSequence[1] = 1;
            if (fibonacciSequence.Length > 2)
            {
                fibonacciSequence[2] = 1;
            }

            for (int i = 3; i <= numberPosition; i++)
            {
                fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
            }
            return fibonacciSequence;
        }
    }
}
