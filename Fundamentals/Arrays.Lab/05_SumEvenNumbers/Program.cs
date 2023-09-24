namespace _05_SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read an array from the console and sum only its even values.
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] %2 == 0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}