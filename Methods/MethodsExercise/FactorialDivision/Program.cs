using System;

namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            long factorialNumber1 = GetFactorial(number1);
            long factorialNumber2 = GetFactorial(number2);

            decimal result = GetFactorialDivision(factorialNumber1, factorialNumber2);

            Console.WriteLine($"{result:f2}");


        }

        static long GetFactorial(long number)
        {
            long factorialNum = number;

            if (number == 0)
            {
                factorialNum = 1;
            }
            else if (number > 0)
            {
                for (long i = number - 1; i > 0; i--)
                {
                    factorialNum *= i;
                }
            }

            return factorialNum;
            
        }

        static decimal GetFactorialDivision(long factorialNumber1, long factorialNumber2)
        {
            decimal num1 = (decimal)factorialNumber1;
            decimal num2 = (decimal)factorialNumber2;
            
            decimal factorialDivision = num1 / num2;

            return factorialDivision;
        }
    }
}
