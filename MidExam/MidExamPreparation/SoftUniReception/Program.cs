using System;

namespace SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employee1Efficiency = int.Parse(Console.ReadLine());
            int employee2Eficiency = int.Parse(Console.ReadLine());
            int employee3Efficiency = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int totalEfficiency = employee1Efficiency + employee2Eficiency + employee3Efficiency;

            int hours = 0;
            int counter = 0;

            while (true)
            {
                if (studentsCount == 0)
                {
                    break;
                }
                else if (counter == 3)
                {
                    hours++;
                    counter = 0;
                }
                else if (studentsCount <= totalEfficiency)
                {
                    hours++;
                    break;
                }
                else
                {
                    studentsCount -= totalEfficiency;
                    hours++;
                    counter++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
