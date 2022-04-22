using System;
using System.Linq;

namespace TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool flag = false;

            for (int wagon = 0; wagon < lift.Length; wagon++)
            {
                for (int capacity = lift[wagon]; capacity < 4; capacity++)
                {
                    lift[wagon] += 1;
                    peopleWaiting -= 1;

                    if (peopleWaiting == 0)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    break;
                }
            }

            if (CheckLiftCapacity(lift) && peopleWaiting == 0)
            {
                Console.WriteLine(String.Join(" ", lift));
            }
            else if (flag)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", lift));
            }
            else
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(String.Join(" ", lift));
            }
        }

        static bool CheckLiftCapacity(int[] lift)
        {
            bool flag = true;

            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] < 4)
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
    }
}
