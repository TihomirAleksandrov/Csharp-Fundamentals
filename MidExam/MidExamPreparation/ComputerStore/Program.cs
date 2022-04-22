using System;

namespace ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string customerType = string.Empty;
            decimal priceWithoutTaxes = 0;
            decimal taxes = 0;

            while (true)
            {
                if (input == "special")
                {
                    customerType = "special";
                    break;
                }
                else if (input == "regular")
                {
                    customerType = "regular";
                    break;
                }
                else
                {
                    decimal price = decimal.Parse(input);

                    if (price < 0)
                    {
                        Console.WriteLine("Invalid price!");
                        input = Console.ReadLine();
                        continue;
                    }

                    priceWithoutTaxes += price;
                    taxes += GetTax(price);

                    input = Console.ReadLine();
                }
            }

            decimal priceWithTax = priceWithoutTaxes + taxes;


            if (priceWithTax == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else if (customerType == "special")
            {
                priceWithTax -= (priceWithTax * (decimal)0.1);
                GetOutput(priceWithoutTaxes, taxes, priceWithTax);
            }
            else
            {
                GetOutput(priceWithoutTaxes, taxes, priceWithTax);
            }
        }

        static decimal GetTax(decimal price)
        {
            decimal tax = price * (decimal)0.2;
            return tax;
        }

        static void GetOutput(decimal priceWithoutTaxes, decimal taxes, decimal priceWithTax)
        {
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {priceWithTax:f2}$");
        }
    }
}
