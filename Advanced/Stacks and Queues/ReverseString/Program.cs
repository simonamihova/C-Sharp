using System.Collections.Generic;

namespace ReverseString
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var str in input)
            {
                stack.Push(str);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}