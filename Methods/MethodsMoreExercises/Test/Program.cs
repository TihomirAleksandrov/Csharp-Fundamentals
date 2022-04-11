using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cabins = { 0, 1, 0, 0 };

            for (int i = 0; i < cabins.Length; i++)
            {
                for (int j = cabins[i]; j < 4; j++)
                {
                    cabins[i] += 1;
                }
                Console.WriteLine(String.Join(" ", cabins));
            }
            
        }
    }
}
