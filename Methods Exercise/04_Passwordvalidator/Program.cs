namespace _04_Passwordvalidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a program that checks if a given password is valid.
                The password validation rules are:
                • It should contain 6 – 10 characters (inclusive)
                • It should contain only letters and digits
                • It should contain at least 2 digits
                If it is not valid, for any unfulfilled rule print the corresponding message:
                • "Password must be between 6 and 10 characters"
                • "Password must consist only of letters and digits"
                • "Password must have at least 2 digits"

             */

            //Input
            char[] password = Console.ReadLine()
                                     .ToCharArray();
        }
        static bool PasswordLegthCheck(char[] password)
        {
            bool checker = true;
            int passwordLength = password.Length;
            if(passwordLength < 6 || passwordLength > 11 )
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                checker = false;
            }
            else if(passwordLength < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                checker = false;
            }
            return checker;
        }
        static bool PasswordValueCheck(char[] password)
        {
            bool isADigit = true;
            bool isALetter = true;
            bool checker = true; 
            foreach (char c in password)
            {
                 isADigit = Char.IsDigit(c);
                 isALetter = Char.IsLetter(c);
            }
            if(!isADigit || !isALetter) 
            {
                Console.WriteLine("Password must consist only of letters and digits");
                checker= false;
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
                if(isADigit)
                {
                    count++;
                }
            }
            if(count < 2)
            {
                checker = false;
            }
            return checker;
        }
    }
}