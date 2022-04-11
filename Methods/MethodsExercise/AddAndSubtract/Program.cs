using System;

namespace AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum1 = AddFirstTwoNumbers(num1, num2);

            int result = SubtractSumWithThirdNum(sum1, num3);

            Console.WriteLine(result);
        }

        static int AddFirstTwoNumbers (int num1, int num2)
        {
            return num1 + num2;
        }

        static int SubtractSumWithThirdNum(int sum, int num3)
        {
            return sum - num3;
        }
    }
}
