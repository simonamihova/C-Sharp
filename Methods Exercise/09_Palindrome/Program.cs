namespace _09_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isPalindrome = false;

            while (input != "END")
            {
                char[] num = input.Split(""). ToCharArray();
                char[] revNum = new char[num.Length];

                for (int i = 0;i < num.Length; i++)
                {
                    for(int j = num.Length-1; j >= 0; j--)
                    {
                        revNum[j] = num[i];
                    }
                }

                isPalindrome = IsPalindrome(num, revNum);
                Console.WriteLine(isPalindrome.ToString().ToLower());
                input = Console.ReadLine();
            }
        }
        static bool IsPalindrome(char[] num, char[] revNum)
        {
            bool temp = false;
            for(int i = 0; i < num.Length; i++) 
            {
                if (num[i] == revNum[i])
                {
                    temp = true;
                }
            }
            return temp;
        }
    }
}