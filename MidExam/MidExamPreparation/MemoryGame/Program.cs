using System;
using System.Linq;
using System.Collections.Generic;

namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();
            int counter = 1;
            while (input != "end")
            {
                int[] indexes = input.Split().Select(int.Parse).ToArray();
                int index1 = indexes[0];
                int index2 = indexes[1];

                if ((index1 < 0 || index1 >= list.Count) || (index2 < 0 || index2 >= list.Count) || index1 == index2)
                {
                    list = AddElements(list, counter);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (list[index1] == list[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {list[index1]}!");
                    list = RemoveMatchingElements(list, index1, index2);
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (list.Count == 0)
                {
                    Console.WriteLine($"You have won in {counter} turns!");
                    break;
                }

                counter++;
                input = Console.ReadLine();
            }

            if (list.Count != 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", list));
            }
        }

        static List<string> AddElements(List<string> list, int counter)
        {
            int middleIndex = list.Count / 2;
            string element = $"-{counter}a";

            list.Insert(middleIndex, element);
            list.Insert(middleIndex, element);

            return list;
        }

        static List<string> RemoveMatchingElements(List<string> list, int index1, int index2)
        {
            if (index1 > index2)
            {
                list.RemoveAt(index1);
                list.RemoveAt(index2);
            }
            else
            {
                list.RemoveAt(index2);
                list.RemoveAt(index1);
            }

            return list;
        }
    }
}
