using System;
using System.Linq;

namespace EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool flag = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

               
                if (numbers.Length == 1)
                 {
                     flag = true;
                     Console.WriteLine(i);
                     break;
                 }
                else
                {
                    for (int left = 0; left < i; left++)
                    {
                        leftSum += numbers[left];
                    }

                    for (int right = numbers.Length-1; right > i; right--)
                    {
                        rightSum += numbers[right];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine("no");
            }
        }
    }
}
