using System;
using System.Text;

namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeatNum = int.Parse(Console.ReadLine());

            string repeatString = RepeatString(text, repeatNum);
            Console.WriteLine(repeatString);
        }

        static string RepeatString(string text, int repeatNum)
        {
            StringBuilder repeatedString = new StringBuilder();

            for (int i = 0; i < repeatNum; i++)
            {
                repeatedString.Append(text);
            }

            return repeatedString.ToString();
        }
    }
}
