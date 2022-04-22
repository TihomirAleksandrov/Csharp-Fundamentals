using System;
using System.Linq;
using System.Collections.Generic;

namespace MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            

            while (input != "End")
            {
                string[] inputArray = input.Split().ToArray();
                int index = int.Parse(inputArray[1]);

                if (inputArray[0] == "Shoot")
                {
                    int power = int.Parse(inputArray[2]);
                    targets = ShootTargets(targets, index, power);
                }
                else if (inputArray[0] == "Add")
                {
                    int value = int.Parse(inputArray[2]);
                    
                    if (index < 0 || index >= targets.Count)
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    else
                    {
                        targets.Insert(index, value);
                    }
                }
                else if (inputArray[0] == "Strike")
                {
                    int radius = int.Parse(inputArray[2]);

                    if ((index < 0 || index >= targets.Count) || !CheckRadius(targets, index, radius))
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    else
                    {
                        targets = StrikeTarget(targets, index, radius);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join("|", targets));
        }

        static List<int> ShootTargets(List<int> targets, int index, int power)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets[index] -= power;

                if (targets[index] <= 0)
                {
                    targets.RemoveAt(index);
                }
            }

            return targets;
        }

        static bool CheckRadius(List<int> targets, int index, int radius)
        {
            bool flag = true;
            
            if ((index - radius) < 0 || (index + radius) >= targets.Count)
            {
                flag = false;
            }

            return flag;
        }

        static List<int> StrikeTarget(List<int> targets, int index, int radius)
        {
            int startIndex = index - radius;
            int endIndex = index + radius;

            for (int i = startIndex; i <= endIndex; i++)
            {
                targets.RemoveAt(startIndex);
            }

            return targets;
        }
    }
}
