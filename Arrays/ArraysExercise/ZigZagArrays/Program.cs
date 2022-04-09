using System;
using System.Linq;

namespace ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] savedNumbers1 = new int[input];
            int[] savedNumbers2 = new int[input];
            int[] number1 = new int[1];
            int[] number2 = new int[1];

            for (int i = 0; i < input; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                number1[0] = numbers[0];
                number2[0] = numbers[1];

                if ((i + 1) % 2 == 0)
                {
                    savedNumbers1[i] = number2[0];
                    savedNumbers2[i] = number1[0];
                }
                else
                {
                    savedNumbers1[i] = number1[0];
                    savedNumbers2[i] = number2[0];
                }
            }
            Console.WriteLine(String.Join(" ", savedNumbers1));
            Console.WriteLine(String.Join(" ", savedNumbers2));
        }
    }
}
