namespace _11_MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a method that receives two numbers and an operator, calculates the result and returns it. You will be given
                three lines of input. The first will be the first number, the second one will be the operator and the last one will be
                the second number.
                The possible operators are: /, *, + and -.
             */

            int fNumber = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine()); 
            int lNumber  = int.Parse(Console.ReadLine());

            double finalResult = 0;

            switch(operation)
            {
                case '/':
                    finalResult = division(fNumber, operation, lNumber);
                    break;
                case '*':
                    finalResult = multiplication(fNumber, operation, lNumber);
                    break;
                case '+':
                    finalResult = sum(fNumber, operation, lNumber);
                    break;
                case '-':   
                    finalResult = substarction(fNumber, operation, lNumber);
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }
            Console.WriteLine(finalResult.ToString());

        }
        //The possible operators are: /, *, + and -.

        static double division (int a, char operation, int b)
        {
            double result = a / b;
            return result;
        }
        static double multiplication(int a, char operation, int b)
        {
            double result = a * b;
            return result;
        }
        static double sum(int a, char operation, int b)
        {
            double result = a + b;
            return result;
        }
        static double substarction(int a, char operation, int b)
        {
            double result = a - b;
            return result;
        }
    }
}