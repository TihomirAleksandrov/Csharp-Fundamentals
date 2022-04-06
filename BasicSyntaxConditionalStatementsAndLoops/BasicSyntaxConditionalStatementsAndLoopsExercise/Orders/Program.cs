using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var finalSum = 0.0;

            for (int i = 1; i <= input; i++)
            {
                var price = double.Parse(Console.ReadLine());
                var days = int.Parse(Console.ReadLine());
                var capsulesNum = int.Parse(Console.ReadLine());

                var totalPrice = ((days * capsulesNum) * price);

                Console.WriteLine($"The price for the coffee is: ${totalPrice:f2}");
                finalSum += totalPrice;
            }

            Console.WriteLine($"Total: ${finalSum:f2}");
        }
    }
}
