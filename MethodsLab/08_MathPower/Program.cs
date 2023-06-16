namespace _08_MathPower
{
    internal class Program
    {
        static void Main()
        {
            //Input
            int baseNum = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            int result = MathPower(baseNum, power);
            Console.WriteLine(result);
        }

        static int MathPower(int baseNum, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}