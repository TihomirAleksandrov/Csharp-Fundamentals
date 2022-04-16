using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newNumbers = CopyLists(numbers);

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();

                int number1 = 0;
                int number2 = 0;


                switch (tokens[0])
                {
                    case "Contains":
                        number1 = int.Parse(tokens[1]);
                        CheckIfListContains(numbers, number1);
                        break;
                    case "PrintEven":
                        PrintEvenNums(numbers);
                        break;
                    case "PrintOdd":
                        PrintOddNums(numbers);
                        break;
                    case "GetSum":
                        SumAllNumbers(numbers);
                        break;
                    case "Filter":
                        number2 = int.Parse(tokens[2]);
                        string condition = tokens[1];
                        FilterNums(numbers, condition, number2);
                        break;
                    case "Add":
                        number1 = int.Parse(tokens[1]);
                        newNumbers = AddNumberToList(newNumbers, number1);
                        break;
                    case "Remove":
                        number1 = int.Parse(tokens[1]);
                        newNumbers = RemoveNumberFromList(newNumbers, number1);
                        break;
                    case "RemoveAt":
                        number1 = int.Parse(tokens[1]);
                        newNumbers = RemoveAtIndexFromList(newNumbers, number1);
                        break;
                    case "Insert":
                        number1 = int.Parse(tokens[1]);
                        number2 = int.Parse(tokens[2]);
                        newNumbers = InsertNumberInList(newNumbers, number1, number2);
                        break;
                }

                command = Console.ReadLine();
            }

            if (!CompareLists(numbers, newNumbers))
            {
                Console.WriteLine(String.Join(" ", newNumbers));
            }
        }

        static List<int> CopyLists(List<int> numbers)
        {
            List<int> newNumbers = new List<int>();
            
            for (int i = 0; i < numbers.Count; i++)
            {
                newNumbers.Add(numbers[i]);
            }

            return newNumbers;
        }
        
        static bool CompareLists(List<int> numbers, List<int> newNumbers)
        {
            if (numbers.Count != newNumbers.Count)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] != newNumbers[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void CheckIfListContains(List<int> numbers, int number)
        {
            if (numbers.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        static void PrintEvenNums (List<int> numbers)
        {
            List<int> evenNums = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNums.Add(numbers[i]);
                }
            }

            Console.WriteLine(String.Join(" ", evenNums));
        }

        static void PrintOddNums(List<int> numbers)
        {
            List<int> oddNums = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddNums.Add(numbers[i]);
                }
            }

            Console.WriteLine(String.Join(" ", oddNums));
        }

        static void SumAllNumbers(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }

        static void FilterNums(List<int> numbers, string condition, int number)
        {
            List<int> filteredNums = new List<int>();
            
            switch (condition)
            {
                case "<":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < number)
                        {
                            filteredNums.Add(numbers[i]);
                        }
                    }
                    break;
                case ">":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > number)
                        {
                            filteredNums.Add(numbers[i]);
                        }
                    }
                    break;
                case ">=":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] >= number)
                        {
                            filteredNums.Add(numbers[i]);
                        }
                    }
                    break;
                case "<=":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= number)
                        {
                            filteredNums.Add(numbers[i]);
                        }
                    }
                    break;
            }
            Console.WriteLine(String.Join(" ", filteredNums));
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
