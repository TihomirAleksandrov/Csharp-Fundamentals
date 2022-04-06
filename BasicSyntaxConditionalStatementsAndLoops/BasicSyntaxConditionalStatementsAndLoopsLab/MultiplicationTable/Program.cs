using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = num2; i <= 10; i++)
            {
                sum = num1 * i;
                Console.WriteLine($"{num1} X {i} = {sum}");
            }

            if (num2 > 10)
            {
                sum = num1 * num2;
                Console.WriteLine($"{num1} X {num2} = {sum}");
            }
        }
    }
}
