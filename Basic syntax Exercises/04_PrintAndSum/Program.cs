namespace _04_PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = int.Parse(Console.ReadLine());
            int endValue = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = startValue; i <= endValue; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}