using System;
using System.Linq;
using System.Collections.Generic;

namespace HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();

            int inputNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNum; i++)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split();

                if (tokens[2] != "not")
                {
                    if (CheckForSameName(guests, tokens[0]))
                    {
                        Console.WriteLine($"{tokens[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(tokens[0]);
                    }
                }
                else
                {
                    if (CheckForSameName(guests, tokens[0]))
                    {
                        guests.Remove(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is not in the list!");
                    }
                }
            }

            PrintGuests(guests);
        }

        static bool CheckForSameName(List<string> guests, string name)
        {
            for (int i = 0; i < guests.Count; i++)
            {
                if (guests[i] == name)
                {
                    return true;
                }
            }

            return false;
        }

        static void PrintGuests(List<string> guests)
        {
            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
