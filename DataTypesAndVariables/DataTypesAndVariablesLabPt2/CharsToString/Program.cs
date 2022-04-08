using System;

namespace CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            char input3 = char.Parse(Console.ReadLine());

            Console.WriteLine($"{input1}{input2}{input3}");
        }
    }
}
