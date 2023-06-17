namespace _01_MetresToKilometres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int metres = int.Parse(Console.ReadLine());
            float km = metres / 1000.0f;
            Console.WriteLine($"{km:F2}");

            
        }
    }
}