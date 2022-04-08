using System;

namespace RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.Parse(Console.ReadLine());
            
            for (int currNum = 2; currNum <= maxNum; currNum++)
            {
                bool flag = true;

                for (int divisionNum = 2; divisionNum < currNum; divisionNum++)
                {
                    if (currNum % divisionNum == 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    Console.WriteLine($"{currNum} -> true");
                }
                else
                {
                    Console.WriteLine($"{currNum} -> false");
                }
            }
        }
    }
}
