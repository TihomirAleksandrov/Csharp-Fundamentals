using System;

namespace DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputDay = int.Parse(Console.ReadLine());

            string[] weekDays =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            if (inputDay <= 0 || inputDay > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(weekDays[inputDay - 1]);
            }
        }
    }
}
