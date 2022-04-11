using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string beverage = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            GetTotalPrice(beverage, quantity);
        }

        static void GetTotalPrice(string beverage,int quantity)
        {
            double price = 0;

            switch (beverage)
            {
                case "coffee":
                    price = quantity * 1.50;
                    break;
                case "water":
                    price = quantity * 1.00;
                    break;
                case "coke":
                    price = quantity * 1.40;
                    break;
                case "snacks":
                    price = quantity * 2.00;
                    break;
            }

            Console.WriteLine($"{price:f2}");  
        }
    }
}
