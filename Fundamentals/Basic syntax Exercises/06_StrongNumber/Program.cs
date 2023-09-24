using System;

namespace _06_StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            if (IsStrongNumber(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        static bool IsStrongNumber(int number)
        {
            int tempNumber = number;
            int sum = 0;

            while (tempNumber > 0)
            {
                int digit = tempNumber % 10;
                sum += Factorial(digit);
                tempNumber /= 10;
            }

            return sum == number;
        }

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
        }


    }
    
}