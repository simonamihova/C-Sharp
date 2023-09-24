using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Password_Enctypting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(.+)>([0-9]{3})(\|)([a-z]{3})(\|)([A-Z]{3})(\|)([^<]{3})<(\1)";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection matches = Regex.Matches(input, pattern);
                bool isPasswordValid = regex.IsMatch(input);

                string password = string.Empty;
                foreach (Match match in matches)
                {
                    string digits = match.Groups[2].Value;
                    string lowerCase = match.Groups[4].Value;
                    string upperCase = match.Groups[6].Value;
                    string symbols = match.Groups[8].Value;
                    password = String.Concat(digits, lowerCase, upperCase, symbols);
                }

                

                if (!isPasswordValid)
                {
                    
                    Console.WriteLine("Try another password!");
                }
                else
                {
                    Console.WriteLine($"Password: {password}");
                }

            }
        }
    }
}