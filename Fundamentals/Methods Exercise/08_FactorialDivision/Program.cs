namespace _08_FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Read two integers. Calculate the factorial of each number. Divide the first result by the second and print the result
                of the division formatted to the second decimal point.
             */

            //Input
            int a = int.Parse(Console.ReadLine());
            int  b = int.Parse(Console.ReadLine());

           
            Console.WriteLine($"{(GetFactorial(a)/ GetFactorial(b)):F2}");
        }
        static decimal GetFactorial(decimal num)
        {
            if (num <= 1)
            {
                return 1;  
            }
            return num * GetFactorial(num - 1);

        }
        
    }
}