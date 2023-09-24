using System;

namespace _04_Passwordvalidator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[] password = Console.ReadLine()
                                     .ToCharArray();

            bool lengthCheck = false;
            bool valueCheck = false;
            bool digitsCheck = false;

            lengthCheck = PasswordLegthCheck(password);
            valueCheck = PasswordValueCheck(password);
            digitsCheck = DigitCountCheck(password);
            if (lengthCheck && valueCheck && digitsCheck)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool PasswordLegthCheck(char[] password)
        {
            bool checker = true;
            int passwordLength = password.Length;
            if (passwordLength < 6 || passwordLength > 11)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                checker = false;
            }
            return checker;
        }
        static bool PasswordValueCheck(char[] password)
        {
            bool isADigitOrLetter = true;
            bool checker = true;
            foreach (char c in password)
            {
                bool tempCheck = true;
                tempCheck = Char.IsLetterOrDigit(c);
                if (tempCheck != true)
                {
                    isADigitOrLetter = false;
                }
            }
            if (isADigitOrLetter != true)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                checker = false;
            }
            return checker;
        }

        static bool DigitCountCheck(char[] password)
        {
            bool checker = true;
            int count = 0;
            foreach (char c in password)
            {
                bool isADigit = Char.IsDigit(c);
                if (isADigit)
                {
                    count++;
                }
            }
            if (count < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                checker = false;
            }
            return checker;
        }
    }
}