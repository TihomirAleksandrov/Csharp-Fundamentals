using System;

namespace ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            var countryName = Console.ReadLine();
            var language = "";

            switch (countryName)
            {
                case "England":
                case "USA":
                    language = "English";
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    language = "Spanish";
                    break;
                default:
                    language = "unknown";
                    break;
            }
            
            Console.WriteLine(language);
        }
    }
}
