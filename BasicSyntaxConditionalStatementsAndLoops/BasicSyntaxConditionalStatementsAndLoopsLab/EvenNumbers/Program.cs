﻿using System;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = int.Parse(Console.ReadLine());

                if (input % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(input)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
