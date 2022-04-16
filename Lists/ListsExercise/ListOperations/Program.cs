using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int number = 0;
            int index = 0;

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split();
                
                if (tokens[0] == "Add")
                {
                    number = int.Parse(tokens[1]);
                    numbers.Add(number);
                }
                else if (tokens[0] == "Insert")
                {
                    number = int.Parse(tokens[1]);
                    index = int.Parse(tokens[2]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }
                }
                else if (tokens[0] == "Remove")
                {
                    index = int.Parse(tokens[1]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (tokens[0] == "Shift")
                {
                    int count = int.Parse(tokens[2]);

                    if (tokens[1] == "left")
                    {
                        numbers = ShiftNumbersToLeft(numbers, count);
                    }
                    else if (tokens[1] == "right")
                    {
                        numbers = ShiftNumbersToRight(numbers, count);
                    }
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }

        static List<int> ShiftNumbersToLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }

            return numbers;
        }

        static List<int> ShiftNumbersToRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }

            return numbers;
        }
    }
}
