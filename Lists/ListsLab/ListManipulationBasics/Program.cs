using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
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
                int number1 = 0;
                int number2 = 0;
                switch (tokens[0])
                {
                    case "Add":
                        number1 = int.Parse(tokens[1]);
                        numbers = AddNumberToList(numbers, number1);
                        break;
                    case "Remove":
                        number1 = int.Parse(tokens[1]);
                        RemoveNumberFromList(numbers, number1);
                        break;
                    case "RemoveAt":
                        number1 = int.Parse(tokens[1]);
                        RemoveAtIndexFromList(numbers, number1);
                        break;
                    case "Insert":
                        number1 = int.Parse(tokens[1]);
                        number2 = int.Parse(tokens[2]);
                        InsertNumberInList(numbers, number1, number2);
                        break;
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }

        static List<int> AddNumberToList(List<int> numbers, int number)
        {
            numbers.Add(number);
            return numbers;
        }

        static List<int> RemoveNumberFromList(List<int> numbers, int number)
        {
            numbers.Remove(number);
            return numbers;
        }

        static List<int> RemoveAtIndexFromList(List<int> numbers, int number)
        {
            numbers.RemoveAt(number);
            return numbers;
        }

        static List<int> InsertNumberInList(List<int> numbers, int number, int index)
        {
            numbers.Insert(index, number);
            return numbers;
        }
    }
}
