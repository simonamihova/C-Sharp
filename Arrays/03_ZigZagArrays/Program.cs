namespace _03_ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a program that creates 2 arrays. You will be given an integer n. On the next n lines, you will get 2 integers.
            Form 2 new arrays in a zig-zag pattern as shown below.*/

            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n / 2];
            int[] arr2 = new int[n / 2];
            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());

            }
        }
    }
}