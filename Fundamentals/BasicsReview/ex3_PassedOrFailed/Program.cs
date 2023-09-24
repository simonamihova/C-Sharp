namespace ex3_PassedOrFailed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float number = float.Parse(Console.ReadLine());
            if (number >= 3)
            {

                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}