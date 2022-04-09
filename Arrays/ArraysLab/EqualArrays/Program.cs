using System;
using System.Linq;

namespace EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool flag = true;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    sum += array1[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }  
        }
    }
}
