using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                int element = int.Parse(tokens[1]);

                if (tokens[0] == "Delete")
                {
                    numbers = RemoveElement(numbers, element);
                }
                else if (tokens[0] == "Insert")
                {
                    int position = int.Parse(tokens[2]);
                    numbers = InsertElement(numbers, element, position);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }

        static List<int> RemoveElement(List<int> numbers, int element)
        {
           List<int> newNumbers = new List<int>();
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != element)
                {
                    newNumbers.Add(numbers[i]);
                }
            }

            return newNumbers;
        }

        static List<int> InsertElement(List<int> numbers, int element, int position)
        {
            numbers.Insert(position, element);

            return numbers;
        }
    }
}
