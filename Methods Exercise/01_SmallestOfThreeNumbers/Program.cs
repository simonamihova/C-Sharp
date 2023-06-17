
namespace _01_SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = GetMaxOfThree(a, b, c);
            Console.WriteLine(result);


        }

        static int GetMaxOfThree(int a, int b, int c)
        {
            int maxNum = 0;
            maxNum = Math.Max(a, b);
            if(maxNum > Math.Max(b,c))
            {
                return maxNum;
            }
            else
            {
                return Math.Max(b, c);
            }
        }
    }
}