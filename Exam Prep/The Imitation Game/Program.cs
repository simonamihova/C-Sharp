namespace The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = string.Empty;
            while (true)
            {
               input = Console.ReadLine();

                if (input == "Decode")
                {
                    break;
                }

                string[] inputArr = input.Split("|");

                if (inputArr[0] == "Move")
                {
                    int charCount = int.Parse(inputArr[1]);
                    string temp = message.Substring(0, charCount);
                    message = message.Remove(0,charCount);
                    message = message + temp; 
                }

                if (inputArr[0] == "Insert")
                {
                    int index = int.Parse(inputArr[1]);
                    string insertContent = inputArr[2];
                    message = message.Insert(index, insertContent);
                }

                if (inputArr[0] == "ChangeAll")
                {
                    string substring = inputArr[1];
                    string replacement = inputArr[2];
                    message = message.Replace(substring, replacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");

        }
    }
}