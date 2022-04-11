using System;

namespace CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetRectangleArea(width, height);
            Console.WriteLine(area);
        }

        static double GetRectangleArea(double value1, double value2)
        {
            return value1 * value2;
        }
    }
}
