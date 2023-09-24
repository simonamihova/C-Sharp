using System.Text;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> wordsDefinitions = new Dictionary<string, List<string>>();

            string[] words = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] wordsToBeTested = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string teacherCommand = Console.ReadLine();

            for (int i = 0; i < words.Length; i++)
            {
                string[] keyValuePairs = words[i].Split(": ");

                if (!wordsDefinitions.ContainsKey(keyValuePairs[0]))
                {
                    wordsDefinitions[keyValuePairs[0]] = new List<string>();
                    wordsDefinitions[keyValuePairs[0]].Add(keyValuePairs[1]);
                }
                else
                {
                    wordsDefinitions[keyValuePairs[0]].Add(keyValuePairs[1]);
                }
            }

            if (teacherCommand == "Test")
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < wordsToBeTested.Length; i++)
                {
                    if (wordsDefinitions.ContainsKey(wordsToBeTested[i]))
                    {
                        sb.AppendLine($"{wordsToBeTested[i]}:");
                        foreach (var definiton in wordsDefinitions[wordsToBeTested[i]])
                        {
                            sb.AppendLine($" -{definiton}");
                        }
                    }
                }

                Console.WriteLine(sb.ToString().Trim());
            }

            if (teacherCommand == "Hand Over")
            {
                StringBuilder sb = new StringBuilder();

                foreach (KeyValuePair<string, List<string>> keyValuePair in wordsDefinitions)
                {
                    sb.Append($"{keyValuePair.Key} ");
                }

                Console.WriteLine(sb.ToString().Trim());
            }
        }
    }
}