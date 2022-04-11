using System;

namespace PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangleRange = int.Parse(Console.ReadLine());

            for (int i = 1; i <= triangleRange; i++)
            {
                GetTriangle(triangleRange, i);
            }
            
            for (int i = triangleRange - 1; i >= 0; i--)
            {
                GetTriangle(triangleRange, i);
            }
        }

        static void GetTriangle(int triangleRange, int currentRange)
        {
            for (int i = 1; i <= currentRange; i++)
            {
                Console.Write($"{i} ");
            }
            
            Console.WriteLine();
        }
    }
}
