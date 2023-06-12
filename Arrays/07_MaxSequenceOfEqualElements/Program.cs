namespace _07_MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             0 1 1 5 2 2 6 3 3 
             2 1 1 2 3 3 2 2 2 1
            */
            string[] input = Console.ReadLine().Split(" ");
            int bestCount = 0;
            string symbol = ""; 
            for (int i = 0; i < input.Length; i++)
            {
                int count = 1;
                for( int j = i + 1; j < input.Length ; j++ ) 
                {
                    if (input[i] == input[j])
                    {
                        count++;
                        if (bestCount < count)
                        {
                            bestCount = count;
                            symbol = input[i];
                        }
                        
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int x = 0; x < bestCount; x++)
            {
                Console.Write($"{symbol} ");
            }
        }
    }
}