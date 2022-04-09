using System;

namespace PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] numbers = new int[input];

            for (int i = 0; i < input; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numbers);

            Console.WriteLine(string.Join(" ",numbers));
            
        }
    }
}
