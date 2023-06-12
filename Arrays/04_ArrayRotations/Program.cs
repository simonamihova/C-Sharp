namespace _04_ArrayRotations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Create a program that receives an array and several rotations that you have to perform. The rotations are done by
              moving the first element of the array from the front to the back. Print the resulting array. */

            string[] arr = Console.ReadLine().Split(" ");
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string firstElement = arr[0];

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = firstElement;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}