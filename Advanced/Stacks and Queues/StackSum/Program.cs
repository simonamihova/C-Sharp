namespace StackSum
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine()
                                                     .Split(' ')
                                                     .Select(int.Parse)); 

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] commandArr = command.Split(' ');

                if (commandArr.Contains("add"))
                {
                    int first = int.Parse(commandArr[1]);
                    int second = int.Parse(commandArr[2]);
                    stack.Push(first);
                    stack.Push(second); 

                }
                else if (commandArr.Contains("remove"))
                {
                    int n = int.Parse(commandArr[1]);
                    if (stack.Count >= n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            int sum = 0;

            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");

        }
    }
}