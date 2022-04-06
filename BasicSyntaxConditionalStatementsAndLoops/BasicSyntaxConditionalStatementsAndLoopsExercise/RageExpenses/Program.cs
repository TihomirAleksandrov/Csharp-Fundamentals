using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            var lostGames = int.Parse(Console.ReadLine());
            var headsetPrice = double.Parse(Console.ReadLine());
            var mousePrice = double.Parse(Console.ReadLine());
            var keyboardPrice = double.Parse(Console.ReadLine());
            var displayPrice = double.Parse(Console.ReadLine());
            var headsetCounter = 0;
            var mouseCounter = 0;
            var keyboardCounter = 0;
            var displayCounter = 0;
            var flag = false;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCounter++;
                }
                
                if (i % 3 == 0)
                {
                    mouseCounter++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCounter++;
                    flag = true;
                }

                if (keyboardCounter % 2 == 0 && keyboardCounter != 0 && flag)
                {
                    displayCounter++;
                    flag = false;
                }
            }

            var totalHeadsetPrice = headsetPrice * headsetCounter;
            var totalMousePrice = mousePrice * mouseCounter;
            var totalKeyboardPrice = keyboardPrice * keyboardCounter;
            var totalDisplayPrice = displayPrice * displayCounter;
            var totalPrice = totalDisplayPrice + totalHeadsetPrice + totalKeyboardPrice + totalMousePrice;

            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
