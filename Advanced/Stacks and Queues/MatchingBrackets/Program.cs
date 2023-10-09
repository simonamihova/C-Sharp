using System.Runtime.Serialization.Formatters;

namespace Simole_Calculator
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Stack<int> openingBrackets = new Stack<int>();

            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openingBrackets.Push(i);
                }

                if (input[i] == ')')
                {
                    int openingBracket = openingBrackets.Pop();
                    Console.WriteLine(input.Substring(openingBracket, i - openingBracket + 1));
                }
            }
        }
    }
}