namespace HotPotato
{
    internal class Program
    {

        static int[,] ReadMatrixOnOneLine(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {

                int[] rowValues = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            return matrix;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int tossCount = int.Parse(Console.ReadLine());

            Queue<string> kids = new Queue<string>(input.Split(" "));

            Queue<string> kids2 = new Queue<string>();


            while (kids.Count > 1)
            {
                for(int i = 0; i < tossCount; i++)
                {
                    kids2.Enqueue(kids.Dequeue());
                }
            }

            Console.WriteLine(kids2.Dequeue());
        }
    }
}