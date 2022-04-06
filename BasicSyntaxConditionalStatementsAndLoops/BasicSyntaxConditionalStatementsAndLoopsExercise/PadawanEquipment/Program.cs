using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyAvailable = double.Parse(Console.ReadLine());
            var studentsNum = int.Parse(Console.ReadLine());
            var lightsabersPrice = double.Parse(Console.ReadLine());
            var robesPrice = double.Parse(Console.ReadLine());
            var beltsPrice = double.Parse(Console.ReadLine());
            var beltCounter = 0;

            var lightsabersNum = Math.Ceiling(studentsNum + (studentsNum * 0.1));
            var totalLightsabersPrice = lightsabersNum * lightsabersPrice;

            if (studentsNum >= 6)
            {
                for (int belts = 6; belts <= studentsNum; belts += 6)
                {
                    beltCounter++;
                }
            }

            var freeBeltsPrice = beltCounter * beltsPrice;
            var totalBeltsPrice = studentsNum * beltsPrice - freeBeltsPrice;

            var totalRobesPrice = studentsNum * robesPrice;

            var totalSum = totalLightsabersPrice + totalRobesPrice + totalBeltsPrice;

            if (totalSum <= moneyAvailable)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                var moneyDiff = totalSum - moneyAvailable;
                Console.WriteLine($"John will need {moneyDiff:f2}lv more.");
            }
        }
    }
}
