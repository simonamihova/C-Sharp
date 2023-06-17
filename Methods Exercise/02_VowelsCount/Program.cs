namespace _02_VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                                  .ToCharArray();
            int result = GetVowelsCount(input);
            Console.WriteLine(result);
        }
        static int GetVowelsCount(char[] input)
        {
            int count = 0;
            foreach (char ch in input)
            {
                char c = Char.ToLower(ch);
                //vowels - a, e, i, o, u, y 
                if (c == 'a'
                    || c == 'e'
                    || c == 'i'
                    || c == 'o'
                    || c == 'u'
                    || c == 'y')
                {
                    count++;
                }
            }
            return count;
        }
    }
}