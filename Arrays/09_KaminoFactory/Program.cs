using System.Collections.Generic;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace _09_KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                The clone factory in Kamino got another order to clone troops. But this time you are tasked to find the best DNA
                sequence to use in the production.
                You will receive the DNA length and until you receive the command "Clone them!", you will be receiving a DNA
                sequence of ones and zeroes, split by '!' (one or several).
                You should select the sequence with the longest subsequence of ones. If there are several sequences with the same
                length of the subsequence of ones, print the one with the leftmoststarting index, if there are several sequences with
                the same length and starting index, select the sequence with the greater sum of its elements.
             */   

               /*
                Input / Constraints
                • The first line holds the length of the sequences – integer in the range[1…100].
                • On the next lines, until you receive "Clone them!", you will be receiving sequences(at least one) of ones
                and zeroes, split by '!'(one or several).

                 5
                 1!0!1!1!0
                 0!1!1!0!0
                 Clone them!
                 
                 4
                    1!1!0!1
                    1!0!0!1
                    1!1!0!0
                    Clone them!
            */
            
            int sequenceLength = int.Parse(Console.ReadLine());

            string command = "";
            int[] sequence = new int[sequenceLength];

            
            int[] bestSequence = Array.Empty<int>();
            int count = 0, bestCount = 0; ;
            int sum = 0, bestSum  = 0;
            int index = 0;
            int bestStartIndex = int.MaxValue;

            while (true)
            {
                command = Console.ReadLine();
                if (command == "Clone them!")
                {
                    break;
                }
                sequence = command.Split("!", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();
                index += 1;
                for (int i = 0; i < sequenceLength; i++) 
                {
                    if (sequence[i] == 0)
                    {
                        count = 0;
                        break;
                    }
                    count++;
                    sum++;
                   
                    if (count > bestCount || bestStartIndex > i || sum > bestSum)
                    {
                        bestCount = count;
                        bestSequence = sequence;
                        bestStartIndex = i;
                        bestSum = sum;
                    }
                }

               

            }

            /*
             Output
                The output should be printed on the console and consists of two lines in the following format:
                "Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
                "{DNA sequence, joined by space}"
            */
            Console.WriteLine($"Best DNA sample {index} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));


        }    
    }
}