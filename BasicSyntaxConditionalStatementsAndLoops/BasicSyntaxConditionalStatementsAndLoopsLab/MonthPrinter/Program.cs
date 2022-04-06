using System;

namespace MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = int.Parse(Console.ReadLine());
            var monthText = "";

            switch (month)
            {
                case 1:
                    monthText = "January";
                    break;
                case 2:
                    monthText = "February";
                    break;
                case 3:
                    monthText = "March";
                    break;
                case 4:
                    monthText = "April";
                    break;
                case 5:
                    monthText = "May";
                    break;
                case 6:
                    monthText = "June";
                    break;
                case 7:
                    monthText = "July";
                    break;
                case 8:
                    monthText = "August";
                    break;
                case 9:
                    monthText = "September";
                    break;
                case 10:
                    monthText = "October";
                    break;
                case 11:
                    monthText = "November";
                    break;
                case 12:
                    monthText = "December";
                    break;
            }

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(monthText);
            }
        }
    }
}
