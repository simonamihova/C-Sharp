﻿namespace _05_TopIntegers
{
    internal class Program
    {
        static void Main()
        {
            /*
             1 4 3 2 -> 4 3 2
             14 24 3 19 15 17  -> 24 19 17
             27 19 42 2 13 45 48 -> 48
             */

            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            bool isTopInteger = true;

            for (int i = 0; i < numbers.Length; i++) 
            {
                for (
                    int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write($"{numbers[i]} ");
                }
                isTopInteger = true;
            }
            
























            /*string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            int[] numbers = new int [arr.Length];
            bool tracker = false;

            for (int i = 0; i< arr.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]);
                
               // Console.Write(arr[i]);
            }


               
            for (int j = 0; j < numbers.Length; j++)
            {
                tracker = true;
                
                for (int z = j+1; z < numbers.Length; z++)
                {
                    
                    
                    if(numbers[j] <= numbers[z])
                    {
                        tracker = false;
                       
                    }

                }

                if (tracker == true)
                {
                    Console.Write($"{numbers[j]} ");
                }

            }*/
        }
    }
}