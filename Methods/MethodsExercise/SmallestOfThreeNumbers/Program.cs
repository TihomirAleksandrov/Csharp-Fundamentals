using System;

namespace SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            GetSmallestNumber(num1, num2, num3);
        }

        static void GetSmallestNumber(int num1, int num2, int num3)
        {
            int smallestNum = 0;
            
            if (num1 <= num2 && num1 <= num3)
            {
                smallestNum = num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                smallestNum = num2;
            }
            else if (num3 <= num1 && num3 <= num2)
            {
                smallestNum = num3;
            }

            Console.WriteLine(smallestNum);
        }
    }
}
