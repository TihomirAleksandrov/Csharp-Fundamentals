using System;
using System.Linq;

namespace ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            int input = 0;

            while (command != "end")
            {
                
                if (command.Contains("exchange"))
                {
                    input = GetNumbersFromString(command);

                    if (input >= 0 && input < numbers.Length)
                    {
                        numbers = ExchangeArray(numbers, input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command.Contains("max"))
                {
                    if (command.Contains("even"))
                    {
                        int maxEvenNum = GetMaxEven(numbers);

                        if (CheckForEvenNums(numbers))
                        {
                            Console.WriteLine(maxEvenNum);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (command.Contains("odd"))
                    {
                        int maxOddNum = GetMaxOdd(numbers);
                        if (CheckForOddNums(numbers))
                        {
                            Console.WriteLine(maxOddNum);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (command.Contains("min"))
                {
                    if (command.Contains("even"))
                    {
                        int minEven = GetMinEven(numbers);
                        if (CheckForEvenNums(numbers))
                        {
                            Console.WriteLine(minEven);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (command.Contains("odd"))
                    {
                        int minOdd = GetMinOdd(numbers);
                        if (CheckForOddNums(numbers))
                        {
                            Console.WriteLine(minOdd);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (command.Contains("first"))
                {
                    input = GetNumbersFromString(command);
                    if (command.Contains("even"))
                    {
                        if (input > 0 && input <= numbers.Length)
                        {
                            int[] firstEvenNums = GetFirstEvenNums(numbers, input);

                            if (firstEvenNums.Length == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", firstEvenNums)}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }

                    }
                    else if (command.Contains("odd"))
                    {
                        if (input > 0 && input <= numbers.Length)
                        {
                            int[] firstOddNums = GetFirstOddNums(numbers, input);

                            if (firstOddNums.Length == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", firstOddNums)}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                    }
                }
                else if (command.Contains("last"))
                {
                    input = GetNumbersFromString(command);
                    if (command.Contains("even"))
                    {
                        if (input > 0 && input <= numbers.Length)
                        {
                            int[] lastEvenNums = GetLastEvenNums(numbers, input);

                            if (lastEvenNums.Length == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", lastEvenNums)}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                    }
                    else if (command.Contains("odd"))
                    {
                        if (input > 0 && input <= numbers.Length)
                        {
                            int[] lastOddNums = GetLastOddNums(numbers, input);

                            if (lastOddNums.Length == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", lastOddNums)}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        static int[] ExchangeArray(int[] numbers, int index)
        {
            int[] numbers1 = numbers.Take(index + 1).ToArray();
            int[] numbers2 = numbers.Skip(index + 1).ToArray();

            numbers = numbers2.Concat(numbers1).ToArray();

            return numbers;
        }

        static int GetMaxEven(int[] numbers)
        {
            int maxEven = int.MinValue;
            int evenIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] >= maxEven)
                    {
                        maxEven = numbers[i];
                        evenIndex = i;
                    }
                }
            }

            return evenIndex;
        }

        static int GetMaxOdd(int[] numbers)
        {
            int maxOdd = int.MinValue;
            int oddIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    if (numbers[i] >= maxOdd)
                    {
                        maxOdd = numbers[i];
                        oddIndex = i;
                    }
                }
            }

            return oddIndex;
        }

        static int GetMinEven(int[] numbers)
        {
            int minEven = int.MaxValue;
            int evenIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] <= minEven)
                    {
                        minEven = numbers[i];
                        evenIndex = i;
                    }
                }
            }

            return evenIndex;
        }

        static int GetMinOdd(int[] numbers)
        {
            int minOdd = int.MaxValue;
            int oddIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    if (numbers[i] <= minOdd)
                    {
                        minOdd = numbers[i];
                        oddIndex = i;
                    }
                }
            }

            return oddIndex;
        }

        static bool CheckForEvenNums(int[] numbers)
        {
            bool hasEven = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    hasEven = true;
                    break;
                }
            }

            return hasEven;
        }

        static bool CheckForOddNums(int[] numbers)
        {
            bool hasOdd = false;

            for (int i = 0;i < numbers.Length;i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    hasOdd = true;
                    break;
                }
            }

            return hasOdd;
        }

        static int[] GetFirstEvenNums(int[] numbers, int count)
        {
            int[] firstNums = new int[count];
            int counter = 0;
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    firstNums[index] = numbers[i];
                    counter++;
                    index++;

                    if (counter == count)
                    {
                        return firstNums;
                    }
                }

            }

            int[] lessNums = new int[counter];
            if (counter < count)
            {
                for (int i = 0; i < counter; i++)
                {
                    if (firstNums[i] != 0)
                    {
                        lessNums[i] = firstNums[i];
                    }
                }
            }

            return lessNums;
        }

        static int[] GetFirstOddNums(int[] numbers, int count)
        {
            int[] firstNums = new int[count];
            int counter = 0;
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    firstNums[index] = numbers[i];
                    counter++;
                    index++;

                    if (counter == count)
                    {
                        return firstNums;
                    }
                }
            }

            int[] lessNums = new int[counter];
            if (counter < count)
            {
                for (int i = 0; i < counter; i++)
                {
                    if (firstNums[i] != 0)
                    {
                        lessNums[i] = firstNums[i];
                    }
                }
            }

            return lessNums;
        }

        static int[] GetLastEvenNums(int[] numbers, int count)
        {
            int[] lastNums = new int[count];
            int counter = 0;
            int index = count - 1;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0)
                {
                    lastNums[index] = numbers[i];
                    counter++;
                    index--;

                    if (counter == count)
                    {
                        return lastNums;
                    }
                }
            }

            int[] lessNums = new int[counter];
            if (counter < count)
            {
                index = counter - 1;

                for (int i = 0; i < lastNums.Length; i++)
                {
                    if (lastNums[i] != 0)
                    {
                        lessNums[index] = lastNums[i];
                        index--;
                    }
                }

            }

            return lessNums;
        }

        static int[] GetLastOddNums(int[] numbers, int count)
        {
            int[] lastNums = new int[count];
            int counter = 0;
            int index = count - 1;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 != 0)
                {
                    lastNums[index] = numbers[i];
                    counter++;
                    index--;

                    if (counter == count)
                    {
                        return lastNums;
                    }
                }
            }

            int[] lessNums = new int[counter];
            if (counter < count)
            {
                index = counter - 1;

                for (int i = 0; i < lastNums.Length; i++)
                {
                    if (lastNums[i] != 0)
                    {
                        lessNums[index] = lastNums[i];
                        index--;
                    }
                }

            }

            return lessNums;
        }

        static int GetNumbersFromString(string command)
        {
            string digits = string.Empty;

            for (int i = 0; i < command.Length; i++)
            {
                if (char.IsDigit(command[i]) || command[i] == '-')
                {
                    digits += command[i];
                }
            }

            int number = int.Parse(digits);
            return number;
        }
    }
}
