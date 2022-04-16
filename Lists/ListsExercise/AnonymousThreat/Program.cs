using System;
using System.Linq;
using System.Collections.Generic;

namespace AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPartitions = Console.ReadLine();

            List<string> partitions = inputPartitions.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                List<string> command = Console.ReadLine().Split().ToList();

                int num1 = int.Parse(command[1]);
                int num2 = int.Parse(command[2]);

                if (command[0] == "merge")
                {

                }
                else if (command[0] == "divide")
                {

                }
            }

        }

        static List<string> MergePartitions(List<string> partitions, int startIndex, int endIndex)
        {
            
        }
    }
}
