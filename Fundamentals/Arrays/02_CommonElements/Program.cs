namespace _02_CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Create a program that prints out all common elements in two arrays. You have to compare the elements of the
             second array to the elements of the first.
             */

            string input = Console.ReadLine();

            string[] firstArr = input.Split(' ');

            input = Console.ReadLine();

            string[] secondArr = input.Split(' ');

            for(int i = 0; i< firstArr.Length; i++)
            {
                for(int j = 0; j< secondArr.Length; j++)
                {
                    if (firstArr[i] == secondArr[j])
                    {
                        Console.Write($"{secondArr[j]} ");
                       
                    }
                }
            }
        }
    }
}