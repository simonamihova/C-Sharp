
namespace _01_SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = GetMinOfThree(a, b, c);
            Console.WriteLine(result);




        }

        static int GetMinOfThree(int a, int b, int c)
        {
            
            int firstResult = Math.Min(a, b);
            int secondResult = Math.Min(b, c);
            if(firstResult > secondResult)
            {
                return secondResult;
            }
            else
            {
                return firstResult;
            }
        }
    }
}