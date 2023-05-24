namespace ex12_EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while(true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    int m = Math.Abs(n);
                    Console.WriteLine($"The number is: {m}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}