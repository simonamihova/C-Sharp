namespace ex11_MultiplicationTable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = m; i <= 10; i++)
            {
                result = n * i;
                Console.WriteLine($"{n} X {i} = {result}");

            }

            if (m > 10)
            {
                result = n * m;
                Console.WriteLine($"{n} X {m} = {result}");
            }
        }
    }
}