﻿using System.Numerics;
namespace BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            
            for (int i = 2; i <= input; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}