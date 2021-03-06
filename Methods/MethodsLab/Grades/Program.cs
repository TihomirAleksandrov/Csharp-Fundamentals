using System;

namespace Grades
{
    internal class Program
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine(GetGrade(grade));
        }

        static string GetGrade(double grade)
        {
            string gradeType = string.Empty;

            if (grade >= 2.00 && grade <= 2.99)
            {
                gradeType = "Fail";
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                gradeType = "Poor";
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                gradeType = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                gradeType = "Very good";
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                gradeType = "Excellent";
            }

            return gradeType;
        }
    }
}
