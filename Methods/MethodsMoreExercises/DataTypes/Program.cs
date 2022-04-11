using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            if (dataType == "int")
            {
                int input = int.Parse(Console.ReadLine());
                int result = GetResult(input);
                Console.WriteLine(result);
            }
            else if (dataType == "real")
            {
                double input = double.Parse(Console.ReadLine());
                double result = GetResult(input);
                Console.WriteLine($"{result:f2}");
            }
            else if (dataType == "string")
            {
                string input = Console.ReadLine();
                GetResult(input);
            }
        }

        static int GetResult(int input)
        {
            int result = input * 2;
            return result;
        }

        static double GetResult(double input)
        {
            double result = input * 1.5;
            return result;
        }

        static void GetResult(string input)
        {
            Console.WriteLine($"${input}$");
        }
    }
}
