namespace _06_EqualSums
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ");
            int[] intInput = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                intInput[i] = int.Parse(input[i]);
            }

            int leftSum = 0;
            int rightSum = 0;
            int index = 0;
            bool equalSums = false;

            for (int i = 0; i < intInput.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += intInput[j];
                }
                for (int z = i+1; z < intInput.Length; z++)
                {
                    rightSum += intInput[z];
                }

                if (leftSum == rightSum) 
                {
                    equalSums = true;
                    index = i;
                }
                leftSum = 0;
                rightSum = 0;
            }

            if (equalSums)
            {
                Console.WriteLine($"{index}");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}