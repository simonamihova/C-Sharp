using System.Linq;

namespace _03_ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a program that creates 2 arrays. You will be given an integer n. On the next n lines, you will get 2 integers.
            Form 2 new arrays in a zig-zag pattern as shown below.*/

            int n = int.Parse(Console.ReadLine());

            string[] arr1 = new string[n];
            string[] arr2 = new string[n];

            bool zig = true;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] temp = input.Split(' ');
                if (i%2 == 0)
                {
                    arr1[i] = temp[0];
                    arr2[i] = temp[1];
                } 
                else
                {
                    arr1[i] = temp[1];
                    arr2[i] = temp[0];
                }

            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
            
        }
    }
}