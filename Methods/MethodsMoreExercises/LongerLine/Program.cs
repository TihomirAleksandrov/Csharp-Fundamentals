using System;

namespace LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] coordinates1 = GetCoordinates();
            double[] coordinates2 = GetCoordinates();
            double[] coordinates3 = GetCoordinates();
            double[] coordinates4 = GetCoordinates();


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

        static double[] GetCoordinates()
        {
            double[] coordinates = new double[2];
            
            coordinates[0] = double.Parse(Console.ReadLine());
            coordinates[1] = double.Parse(Console.ReadLine());
            return coordinates;
        }
    }
}
