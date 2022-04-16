using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());

            List<string> products = GetProductsList(inputCount);

            PrintOrderedProducts(products);
        }

        static List<string> GetProductsList(int inputCount)
        {
            List<string> products = new List<string>();
            
            for (int i = 0; i < inputCount; i++)
            {
                products.Add(Console.ReadLine());
            }

            return products;
        }

        static void PrintOrderedProducts(List<string> products)
        {
            products.Sort();
            int count = 1;

            for (int i = 0;i < products.Count;i++)
            {
                Console.WriteLine($"{count}.{products[i]}");
                count++;
            }
        }
    }
}
