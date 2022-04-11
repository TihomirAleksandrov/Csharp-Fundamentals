using System;

namespace TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                int[] digits = GetDigitsArray(i);

                CheckTopNumber(digits);
            }
        }

        static int[] GetDigitsArray(int number)
        {
            string input = number.ToString();
            int[] digits = new int[input.Length];

            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = int.Parse(input[i].ToString());
            }

            return digits;
        }

        static void CheckTopNumber(int[] digits)
        {
            int sum = 0;
            bool isOdd = false;

            for (int j = 0; j < digits.Length; j++)
            {
                sum += digits[j];

                if (digits[j] % 2 != 0)
                {
                    isOdd = true;
                }
            }

            if (sum % 8 == 0 && isOdd)
            {
                Console.WriteLine(String.Join("", digits));
            }

        }
    }
}
