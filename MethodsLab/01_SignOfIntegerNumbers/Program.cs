namespace _01_SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // A single integer is given, create a method that checks if the given number is positive, negative, or zero.
            int number = int.Parse(Console.ReadLine());
            IntegerSign(number);
        }
        static void IntegerSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else if(number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}