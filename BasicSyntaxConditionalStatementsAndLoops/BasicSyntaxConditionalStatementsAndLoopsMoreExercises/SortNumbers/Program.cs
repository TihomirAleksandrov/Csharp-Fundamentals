using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            
            var largest = 0;
            var mid = 0;
            var lowest = 0;

            if (num1 >= num2 && num1 >= num3)
            {
                largest = num1;

                if (num2 >= num3)
                {
                    mid = num2;
                    lowest = num3;
                }
                else
                {
                    mid = num3;
                    lowest = num2;
                }
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                largest = num2;

                if (num1 >= num3)
                {
                    mid = num1;
                    lowest = num3;
                }
                else
                {
                    mid = num3;
                    lowest = num1;
                }
            }
            else
            {
                largest = num3;

                if (num1 >= num2)
                {
                    mid = num1;
                    lowest = num2;
                }
                else
                {
                    mid = num2;
                    lowest = num1;
                }
            }

            Console.WriteLine(largest);
            Console.WriteLine(mid);
            Console.WriteLine(lowest);
        }
    }
}
