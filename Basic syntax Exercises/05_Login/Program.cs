using System.Text;

namespace _05_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] chars = username.ToCharArray();

            StringBuilder sb = new StringBuilder();

            for (int i = chars.Length-1; i>= 0; i--)
            {
                sb.Append(chars[i]);
            }

            string reversed = sb.ToString();

            int counter = 0;

            while (true)
            {
                string password = Console.ReadLine();

                if( password == reversed)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                counter ++;

                if (counter == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
            }
            
        }
    }
}