namespace PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> inputQueue = new Queue<int>(input);

            List<int> temp = new List<int>();

            while(inputQueue.Count > 0)
            {
                int currentNum = inputQueue.Dequeue();
                if (currentNum % 2 == 0)
                { 
                    temp.Add(currentNum);
                }
            }
            Console.WriteLine(String.Join(", ", temp));


        }
    }
}