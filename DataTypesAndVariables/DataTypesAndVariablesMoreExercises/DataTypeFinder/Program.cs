using System;

namespace DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            while (input != "END")
            {
 
                string type = "";
                if (long.TryParse(input, out long type1))
                {
                    type = "integer";
                }
                else if (double.TryParse(input, out double type2))
                {
                    type = "floating point";
                }
                else if (char.TryParse(input, out char type3))
                {
                    type = "character";
                }
                else if (bool.TryParse(input, out bool type4))
                {
                    type = "boolean";
                }
                else
                {
                    type = "string";
                }

                Console.WriteLine($"{input} is {type} type");

                input = Console.ReadLine();
            }
        }
    }
}
