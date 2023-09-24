namespace _08_Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();
            int[] sumArr = new int[nums.Length];
            int sum = 0;
            for (int i = 0;  i < nums.Length - 1; i++)
            {
                sumArr[i] = nums[i] + nums[i + 1];
                for (int j = 0; j < sumArr.Length; j++)
                {
                    sum += sumArr[j];
                }
            }
            Console.WriteLine(sum);

        }
    }
}