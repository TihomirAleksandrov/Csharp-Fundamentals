using System;

namespace GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            switch (dataType)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetType(num1, num2));
                    break;
                case "char":
                    char letter1 = char.Parse(Console.ReadLine());
                    char letter2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetType(letter1, letter2));
                    break;
                case "string":
                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();
                    Console.WriteLine(GetType(input1, input2));
                    break;
            }
        }

        static int GetType(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }

        static char GetType(char letter1, char letter2)
        {
            return letter1 > letter2 ? letter1 : letter2;
        }

        static string GetType(string input1, string input2)
        {
            return input1.CompareTo(input2) > 0 ? input1 : input2;
        }
    }
}
