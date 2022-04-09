using System;
using System.Linq;

namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int positionsChange = int.Parse(Console.ReadLine());

            for (int i = 0; i < positionsChange; i++)
            {
                int firstNum = numbers[0];
                
                for (int j = 0; j < numbers.Length; j++)
                {
                    
                    
                    if (j == numbers.Length - 1)
                    {
                        numbers[j] = firstNum;
                    }
                    else
                    {
                        numbers[j] = numbers[j + 1];
                    }
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
