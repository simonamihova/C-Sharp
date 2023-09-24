using Microsoft.VisualBasic;

namespace _03_ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads an array of strings, reverses it, and prints its elements. The input consists of a sequence
            // of space-separated strings.Print the output on a single line(space separated).
            string[] arr = Console.ReadLine()
                                    .Split()
                                    .ToArray();
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}