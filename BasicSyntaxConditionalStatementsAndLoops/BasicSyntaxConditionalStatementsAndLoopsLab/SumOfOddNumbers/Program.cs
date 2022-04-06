using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            var sum = 0;
            var num = 1;

            for (int i = 1; i <= numbers; i++)
            {
                
                Console.WriteLine(num);
                sum += num;
                num += 2;

            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
