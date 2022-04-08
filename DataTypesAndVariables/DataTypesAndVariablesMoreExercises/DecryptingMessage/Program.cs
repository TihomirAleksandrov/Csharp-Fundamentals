using System;

namespace DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int target = int.Parse(Console.ReadLine());
            string word = "";

            for (int i = 0; i < target; i++)
            {
                char input = char.Parse(Console.ReadLine());

                int letterNum = input + key;

                char letter = (char)(letterNum);

                word += letter.ToString();
            }

            Console.WriteLine(word);
        }
    }
}
