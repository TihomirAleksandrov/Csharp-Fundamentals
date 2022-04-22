using System;
using System.Linq;

namespace ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            int index1 = 0;
            int index2 = 0;

            while (input != "end")
            {
                string[] command = input.Split().ToArray();

                if (command[0] == "swap")
                {
                    index1 = int.Parse(command[1]);
                    index2 = int.Parse(command[2]);
                    numbers = SwapNumbers(numbers, index1, index2);

                }
                else if (command[0] == "multiply")
                {
                    index1 = int.Parse(command[1]);
                    index2 = int.Parse(command[2]);
                    numbers = MultiplyNumbers(numbers, index1, index2);
                }
                else if (command[0] == "decrease")
                {
                    numbers = DecreaseNumbers(numbers);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        static int[] SwapNumbers(int[] numbers, int index1, int index2)
        {
            int[] newNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                newNumbers[i] = numbers[i];
                
                if (i == index1)
                {
                    newNumbers[i] = numbers[index2];
                }
                else if (i == index2)
                {
                    newNumbers[i] = numbers[index1];
                }
            }

            return newNumbers;
        }

        static int[] MultiplyNumbers(int[] numbers, int index1, int index2)
        {
            int[] newNumbers = new int[numbers.Length];
            int multipliedNumber = numbers[index1] * numbers[index2];

            for (int i = 0; i < numbers.Length; i++)
            {
                newNumbers[i] = numbers[i];

                if (i == index1)
                {
                    newNumbers[i] = multipliedNumber;
                }
            }

            return newNumbers;
        }

        static int[] DecreaseNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] -= 1;
            }

            return numbers;
        }
    }
}
