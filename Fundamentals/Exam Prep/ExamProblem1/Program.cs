namespace ExamProblem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] commandArr = command.Split(" ");
                string commandName = commandArr[0];

                if(commandName == "Replace")
                {
                    string currentCahr = commandArr[1];
                    string newChar = commandArr[2];
                    input = input.Replace(currentCahr, newChar);
                    Console.WriteLine(input);
                }
                else if (commandName == "Cut")
                {
                    int startIndex = int.Parse(commandArr[1]);
                    int endIndex = int.Parse(commandArr[2]);

                    if(startIndex < 0 || startIndex > input.Length || endIndex < 0 || endIndex > input.Length)
                    {
                        Console.WriteLine("Invalid indices!");
                        continue;
                    }

                    
                    input =  input.Remove(startIndex, endIndex);
                    Console.WriteLine(input);

                }
                else if (commandName == "Make")
                {
                    string letterCase = commandArr[1];
                    if(letterCase == "Upper")
                    {
                        input = input.ToUpper();
                    }
                    else if(letterCase == "Lower")
                    {
                        input = input.ToLower();
                    }
                    Console.WriteLine(input);
                }
                else if (commandName == "Check")
                {
                    string substring = commandArr[1];
                    if (input.Contains(substring))
                    {
                        Console.WriteLine($"Message contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {substring}");
                    }
                }
                else if (commandName == "Sum")
                {
                    int startIndex = int.Parse(commandArr[1]);
                    int endIndex = int.Parse(commandArr[2]);

                    if (startIndex < 0 || startIndex > input.Length || endIndex < 0 || endIndex > input.Length)
                    {
                        Console.WriteLine("Invalid indices!");
                        continue;
                    }

                    char[] temp = input.Substring(startIndex, endIndex)
                                       .ToCharArray();

                    int sum = 0;

                    foreach (char c in temp)
                    {
                        sum += c;
                    };

                    Console.WriteLine(sum);
                }
            }
        }
    }
}