namespace _06_EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that calculates the difference between the sum of the even and the sum of the odd numbers in
            //an array.

            //1 2 3 4 5 6 -> 3
            //2 4 6 8 10 -> 30
            //3 5 7 9 -> -24

            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                    .ToArray();
            int sumEven = 0;
            int sumOdd = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] %2 == 0)
                {
                    sumEven += numbers[i];
                }
                else
                {
                    sumOdd += numbers[i];
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}