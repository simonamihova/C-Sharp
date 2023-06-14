using System;

namespace _07_EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
            int[] arr2 = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
            bool areIdentical = false;
            int sum = 0;
            int diffIndex = 0;


            for(int i = 0; i < arr1.Length; i++)
            { 
                    if (arr1[i] == arr2[i])
                    {
                        sum += arr2[i];
                        areIdentical = true;
                    }
                    else
                    {
                        diffIndex = i;
                        areIdentical = false;
                        break;
                    }
                
            }

            if (areIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical.Found difference at {diffIndex} index");
            }

        }
    }
}