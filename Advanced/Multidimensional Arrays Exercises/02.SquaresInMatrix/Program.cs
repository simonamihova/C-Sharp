namespace _02.SquaresInMatrix;



internal class Program
    {
        static char[,] ReadMatrixOnOneLine(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowValues = Console.ReadLine().Split(' ');

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col][0]; 
                }
            }
            return matrix;
        }

        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);

            char[,] matrix = ReadMatrixOnOneLine(rows, cols);

            int count = 0;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        count+=1;
                    }
                }
            }

            Console.WriteLine(count);
        }
    
}

