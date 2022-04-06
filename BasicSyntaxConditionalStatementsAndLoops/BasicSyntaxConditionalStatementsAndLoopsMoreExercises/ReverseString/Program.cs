using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                var letter = text[i];
                Console.Write(letter);
            }
        }
    }
}
