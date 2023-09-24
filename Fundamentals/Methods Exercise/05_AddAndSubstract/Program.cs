namespace _05_AddAndSubstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             You will receive 3 integers. Create a method that returns the sum of the first two integers and another method that
                subtracts the third integer from the result of the sum method.
             */

            int a  = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = SumOfTheFirstTwo(a, b);
            result = ThirdIntSubstraction(c, result);

            Console.WriteLine(result);  

        }
        static int SumOfTheFirstTwo(int a, int b)
        {
            return a + b;
        }
        static int ThirdIntSubstraction(int c, int sum)
        {
            sum -= c;
            return sum;
        }
    }
}