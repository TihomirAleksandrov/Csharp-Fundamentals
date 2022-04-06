using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var text = "";

            for (int i = 1; i <= num; i++)
            {
                var input = Console.ReadLine();

                if (input == "0")
                {
                    text += " ";
                    continue;
                }
                
                var digitsNum = input.Length;
                var mainDigit = int.Parse(input[0].ToString());
                var offset = (mainDigit - 2) * 3;
                
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                var letterIndex = (offset + digitsNum - 1);
                var letterNum = letterIndex + 97;
                var letter = (char)(letterNum);

                text += letter;
            }

            Console.WriteLine(text);
        }
    }
}
