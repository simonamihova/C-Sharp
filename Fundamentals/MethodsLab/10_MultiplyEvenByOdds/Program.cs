namespace _10_MultiplyEvenByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                                 .Split("")
                                 .Select(int.Parse)
                                 .ToArray();
            for (int i = 0;i < input.Length; i++)
            {
                input[i] = Math.Abs(input[i]);
            }

            int result = GetMultipleOfEvenAndOdds(input);
            Console.WriteLine(result);
        }
        static int GetSumOfOddDigits(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 != 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        static int GetSumOfEvenDigits(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int[] arr)
        {
            int result = 0;
            int evens = GetSumOfEvenDigits(arr);
            int odds = GetSumOfOddDigits(arr);
            result = evens * odds;
            return result;
        }

    }
   
}