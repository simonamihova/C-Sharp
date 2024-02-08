namespace _01.DiagonalDifference
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
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrixOnOneLine(size, size);


            int primaryDiagonalSum = 0;

            for (int i = 0; i < size; i++)
            {
                primaryDiagonalSum += matrix[i, i];
            }

            int secondaryDiagonalSum = 0;

            for(int i = 0; i < size; i++)
            {
                secondaryDiagonalSum+= matrix[i, size - i - 1];
            }

            int diagonalDifference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(diagonalDifference);
        }

        
    }
}