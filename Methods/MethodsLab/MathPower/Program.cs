using System;

namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            double powerNumber = double.Parse(Console.ReadLine());
            double result = GetMathPower(baseNumber, powerNumber);

            Console.WriteLine(result);
        }

        static double GetMathPower(double baseNumber, double powerNumber)
        {
            double result = 1;
            
            for (int i = 1; i <= powerNumber; i++)
            {
                result *= baseNumber;
            }

            return result;
        }
    }
}
