namespace PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 British Pound = 1.31 Dollars

            int pound = int.Parse(Console.ReadLine());
            float dollar = pound * 1.31f;
            Console.WriteLine($"{dollar:f3}");
        }
    }
}