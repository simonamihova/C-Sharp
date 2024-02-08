using System.Globalization;

namespace Fishing
{
    internal class Program
    {
        static char[,] ReadMatrixOnOneLine(int size)
        {
            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {

                char[] rowValues = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            return matrix;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = ReadMatrixOnOneLine(n);

            int[] currentPosition = new int[2];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 'S')
                    {
                        currentPosition[0] = i;
                        currentPosition[1] = j;
                        
                    }
                }
            }

            string command = Console.ReadLine();
            int fish = 0;
            bool whirlpool = false;
            while (command != "collect the nets")
            {
                matrix[currentPosition[0], currentPosition[1]] = '-';

                if (command == "up")
                {
                    if (currentPosition[0] < 1) { currentPosition[0] = n - 1; }
                    else { currentPosition[0] -= 1; }
                }
                else if (command == "down")
                {
                    if (currentPosition[0] < n - 1) { currentPosition[0] += 1; }
                    else { currentPosition[0] = 0; }
                }
                else if (command == "left")
                {
                    if (currentPosition[1] < 1) { currentPosition[1] = n - 1; }
                    else { currentPosition[1] -= 1; }
                }
                else if (command == "right")
                {
                    if (currentPosition[1] < n - 1) { currentPosition[1] += 1; }
                    else { currentPosition[1] = 0; }
                }


                if (matrix[currentPosition[0], currentPosition[1]] == 'W')
                {
                    fish = 0;
                    whirlpool= true;
                    Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{currentPosition[0]},{currentPosition[1]}]");
                    return;
                }

                if (Char.IsDigit(matrix[currentPosition[0], currentPosition[1]]))
                {
                    int addFish = (int)char.GetNumericValue((matrix[currentPosition[0], currentPosition[1]]));
                    fish += addFish;
                    matrix[currentPosition[0], currentPosition[1]] = '-';
                }

                command = Console.ReadLine();
            }

            if (fish >= 20)
            {
                Console.WriteLine("Success! You managed to reach the quota!");
            }
            else
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - fish} tons of fish more.");
            }
            if (fish > 0)
            {
                Console.WriteLine($"Amount of fish caught: {fish} tons.");


            }

            if (!whirlpool)
            {
                matrix[currentPosition[0], currentPosition[1]] = 'S';
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }


        }
    }
}