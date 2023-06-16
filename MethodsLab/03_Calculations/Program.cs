using System.Collections.Generic;

namespace _03_Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Input
           /*
            • On the first line – a string – "add", "multiply", "subtract", "divide".
            • On the second line – a number.
            • On the third line – another number.
           */

            string command = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    SummingMethod(number1, number2);
                    break;
                case "multiply":
                    MultiplicationMethod(number1, number2);
                    break;
                case "subtract":
                    SubstractionMethod(number1, number2);
                    break;
                case "divide":
                    DivisionMethod(number1, number2);
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }

            static void SummingMethod(int a, int b)
            {
                Console.WriteLine(a + b);
            }

            static void SubstractionMethod(int a, int b)
            {
                Console.WriteLine(a - b);
            }
            static void MultiplicationMethod(int a, int b)
            {
                Console.WriteLine(a * b);
            }
            static void DivisionMethod(int a, int b)
            {
                Console.WriteLine(a / b);
            }
        }
    }
}