namespace RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                  .Split(" ")
                                  .ToArray();

            Random rnd = new Random();

            for (int i  = 0; i < input.Length; i++)
            {
                int randomIndex = rnd.Next(0, input.Length);
                string currentEl = input[i];
                string randomEl = input[randomIndex];

                input[i] = randomEl;
                input[randomIndex] = currentEl;
            }

            foreach (string element in input)
            {
                Console.WriteLine(element);
            }
            
        }
    }
}