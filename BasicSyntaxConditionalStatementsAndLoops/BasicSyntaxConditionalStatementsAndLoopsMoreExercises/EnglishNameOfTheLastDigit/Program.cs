using System;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var lastDigit = num[num.Length - 1];
            var convDigit = lastDigit.ToString();
            var digitName = "";

            switch (convDigit)
            {
                case "1":
                    digitName = "one";
                    break;
                case "2":
                    digitName = "two";
                    break;
                case "3":
                    digitName = "three";
                    break;
                case "4":
                    digitName = "four";
                    break;
                case "5":
                    digitName = "five";
                    break;
                case "6":
                    digitName = "six";
                    break;
                case "7":
                    digitName = "seven";
                    break;
                case "8":
                    digitName = "eight";
                    break;
                case "9":
                    digitName = "nine";
                    break;
                case "0":
                    digitName = "zero";
                    break;
            }

            Console.WriteLine(digitName);
        }
    }
}
