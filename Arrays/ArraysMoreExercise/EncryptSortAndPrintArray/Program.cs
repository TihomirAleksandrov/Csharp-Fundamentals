using System;
using System.Linq;

namespace EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int[] results = new int[inputNum];

            for (int i = 0; i < inputNum; i++)
            {
                string words = Console.ReadLine();
                string onlyLetters = new string(words.Where(Char.IsLetter).ToArray());
                char[] letters = new char[onlyLetters.Length];
                int vowelSum = 0;
                int consonantSum = 0;

                for (int j = 0; j < onlyLetters.Length; j++)
                {
                    letters[j] = onlyLetters[j];

                    switch (letters[j])
                    {
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            vowelSum += letters[j] * words.Length;
                            break;

                        default:
                            consonantSum += letters[j] / words.Length;
                            break;
                    }
                }

                results[i] = vowelSum + consonantSum;
            }

            Array.Sort(results);
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}
