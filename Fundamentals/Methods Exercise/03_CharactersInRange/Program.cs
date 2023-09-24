namespace _03_CharactersInRange
{
    internal class Program
    {
        static void Main()
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());  

            if (start > end)
            {
                char temp = start;
                start = end;
                end = temp;
            }

          GetCharsInRange(start, end);

        }
        static void GetCharsInRange(char start, char end)
        {
            for (int i = start + 1; i < end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}