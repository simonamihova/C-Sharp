namespace _07_RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string inputString = Console.ReadLine();
           int repeatCount = int.Parse(Console.ReadLine());
            string result = RepeatString(inputString, repeatCount);
            Console.WriteLine(result);
        }

        static string RepeatString(string inputString, int repeatCount) 
        {
            string finalString = "";
            for (int i = 0; i < repeatCount; i++)
            {
                finalString += inputString;
            }
            return finalString;
        }
    }
}