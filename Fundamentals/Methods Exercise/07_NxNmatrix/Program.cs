namespace _07_NxNmatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            PrintMatrix (matrixSize);

        }
        static void PrintMatrix(int matrixSize)
        {
            for(int i = 0; i < matrixSize; i++)
            {
                for(int j = 0; j<matrixSize; j++)
                {
                    Console.Write($"{matrixSize} ");
                }
                Console.WriteLine();
            }
        }
    }
}