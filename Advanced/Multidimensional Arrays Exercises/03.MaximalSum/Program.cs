namespace _03.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split();
            int N = int.Parse(dimensions[0]);
            int M = int.Parse(dimensions[1]);

            int[,] matrix = new int[N, M];

            // Read the matrix
            for (int i = 0; i < N; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            
            for (int i = 0; i < N - 2; i++)
            {
                for (int j = 0; j < M - 2; j++)
                {
                    int currentSum = 0;
                    for (int x = 0; x < 3; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            currentSum += matrix[i + x, j + y];
                        }
                    }

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int i = maxRow; i < maxRow + 3; i++)
            {
                for (int j = maxCol; j < maxCol + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}