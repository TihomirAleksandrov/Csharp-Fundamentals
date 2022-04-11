using System;

namespace CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());

            GetCharactersInRange(symbol1, symbol2);
        }

        static void GetCharactersInRange (char symbol1, char symbol2)
        {
            if (symbol1 > symbol2)
            {
                char changedSymbol = symbol1;
                symbol1 = symbol2;
                symbol2 = changedSymbol;
            }
            
            for (int i = symbol1 + 1; i < symbol2; i++)
            {
                char currSymbol = (char)(i);
                Console.Write($"{currSymbol} ");
            }
        }
    }
}
