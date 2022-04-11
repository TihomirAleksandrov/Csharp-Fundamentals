using System;

namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double result = Calculate(number1, @operator, number2);
            
            Console.WriteLine(result);
        }

        static double Calculate(double number1, char @operator, double number2)
        {
            double result = 0;

            switch (@operator)
            {
                case '/':
                    result = number1 / number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
            }

            return result;
        }
    }
}
