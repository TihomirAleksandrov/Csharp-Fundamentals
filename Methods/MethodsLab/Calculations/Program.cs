using System;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string calculationType = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            switch (calculationType)
            {
                case "add":
                    AddNumbers(number1, number2);
                    break;
                case "multiply":
                    MultiplyNumbers(number1, number2);
                    break;
                case "substract":
                    SubstractNumbers(number1, number2);
                    break;
                case "divide":
                    DivideNumbers(number1, number2);
                    break;
            }
        }

        static void AddNumbers(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        static void MultiplyNumbers(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }

        static void SubstractNumbers(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }

        static void DivideNumbers(int number1, int number2)
        {
            Console.WriteLine(number1 / number2);
        }
    }
}
