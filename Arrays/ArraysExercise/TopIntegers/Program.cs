using System;
using System.Linq;

namespace TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool flag = true;
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                flag = true;
                
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    counter++;
                }
            }

            int[] greaterNums = new int[counter];
            int greaterNumsIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                flag = true;

                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    greaterNums[greaterNumsIndex] = numbers[i];
                    greaterNumsIndex++;
                }
            }

            Console.WriteLine(String.Join(" ", greaterNums));
        }
    }
}
