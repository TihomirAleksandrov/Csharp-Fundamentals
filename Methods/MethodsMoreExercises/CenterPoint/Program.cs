using System;

namespace CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] coordinates1 = new double[2];
            double[] coordinates2 = new double[2];

            coordinates1[0] = double.Parse(Console.ReadLine());
            coordinates1[1] = double.Parse(Console.ReadLine());
            coordinates2[0] = double.Parse(Console.ReadLine());
            coordinates2[1] = double.Parse(Console.ReadLine());

            double[] centerPoint = GetCenterPoint(coordinates1, coordinates2);

            Console.WriteLine($"({string.Join(", ", centerPoint)})");
        }

        static double[] GetCenterPoint(double[] coordinates1, double[] coordinates2)
        {
            double result1 = Math.Sqrt(Math.Pow(coordinates1[0], 2) + Math.Pow(coordinates1[1], 2));
            double result2 = Math.Sqrt(Math.Pow(coordinates2[0], 2) + Math.Pow(coordinates2[1], 2));

            if (result1 <= result2)
            {
                return coordinates1;
            }
            else
            {
                return coordinates2;
            }
        }
    }
}
