using System;
using System.Linq;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid1 = CheckPasswordLength(password);
            bool isValid2 = CheckPasswordCharacters(password);
            bool isValid3 = CheckPasswordNumbers(password);

            if (!isValid1)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            
            if (!isValid2)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
           
            if (!isValid3)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValid1 && isValid2 && isValid3)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckPasswordLength (string password)
        {
            bool isValid = false;
            
            if (password.Length < 6 || password.Length > 10)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }

        static bool CheckPasswordCharacters (string password)
        {
            bool flag = false;
            bool isValid = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57 || password[i] >= 65 && password[i] <= 90 || password[i] >= 97 && password[i] <= 122)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }

        static bool CheckPasswordNumbers(string password)
        {
            int digitCounter = 0;
            bool isValid = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    digitCounter++;
                }
            }

            if (digitCounter < 2)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
