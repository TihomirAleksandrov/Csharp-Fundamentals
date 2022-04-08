using System;

namespace BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            bool isOpen = false;
            bool isBalanced = true;

            for (int i = 0; i < target; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if (!isOpen)
                    {
                        isOpen = true;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
                else if (input == ")")
                {
                    if (isOpen)
                    {
                        isOpen = false;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
            }


            if (!isOpen && isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
