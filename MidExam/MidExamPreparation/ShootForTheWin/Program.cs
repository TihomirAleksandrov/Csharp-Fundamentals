using System;
using System.Linq;

namespace ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 0;
            string input = Console.ReadLine();

            while (input != "End")
            {
                int index = int.Parse(input);

                if (index < targets.Length)
                {
                    if (targets[index] != -1)
                    {
                        counter++;
                    }
                }

                targets = ShootTargets(targets, index);

                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", targets)}");
        }

        static int[] ShootTargets(int[] targets, int index)
        {
            for (int i = 0; i < targets.Length; i++)
            {
                if (index == i)
                {
                    if (targets[i] != -1)
                    {
                        targets = ChangeArray(targets, i);
                    }
                }
            }

            return targets;
        }

        static int[] ChangeArray(int[] targets, int index)
        {
            for (int i = 0; i < targets.Length; i++)
            {
                if (i != index)
                {
                    if (targets[i] <= targets[index] && targets[i] != -1)
                    {
                        targets[i] += targets[index];
                    }
                    else if (targets[i] > targets[index] && targets[i] != -1)
                    {
                        targets[i] -= targets[index];
                    }
                }
            }

            targets[index] = -1;
            return targets;
        }
    }
}
