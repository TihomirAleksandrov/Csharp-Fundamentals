using System;
using System.Linq;

namespace CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentence1 = Console.ReadLine().Split().ToArray();
            string[] sentence2 = Console.ReadLine().Split().ToArray();
            int counter = 0;

            for (int i = 0; i < sentence2.Length; i++)
            {
                for (int j = 0; j < sentence1.Length; j++)
                {
                    if (sentence2[i] == sentence1[j])
                    {
                        counter++;
                    }
                }
            }

            string[] commonElements = new string[counter];
            int commonElementsIndex = 0;

            for (int i = 0; i < sentence2.Length; i++)
            {
                for (int j = 0; j < sentence1.Length; j++)
                {
                    if (sentence2[i] == sentence1[j])
                    {
                        commonElements[commonElementsIndex] = sentence1[j];
                        commonElementsIndex++;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", commonElements));
        }
    }
}
