namespace _08_MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                                 .Split(" ")
                                 .Select(int.Parse)
                                 .ToArray();
            int givenSum  = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for( int j = i+1; j < input.Length; j++)
                {
                    if (input[i] != input[j])
                    {
                        sum = input[i] + input[j];
                    }

                    if (sum == givenSum)
                    {
                        Console.WriteLine($"{input[i]} {input[j]}");
                    }
                }
                
            }
                                 
        }
    }
}