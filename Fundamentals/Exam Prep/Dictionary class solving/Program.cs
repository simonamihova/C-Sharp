namespace Dictionary_class_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            String[] allWords = input.Split(" | ").ToArray();

           List<Word> wordList = new List<Word>();
            foreach(string word in allWords)
            {
                string[] tempArr = word.Split(": ");
                string wordd = tempArr[0];
                string description = tempArr[1];

                Word tempObject = new Word();
                tempObject.WordName = wordd;
                tempObject.WordDescriptions.Add(description);
                wordList.Add(tempObject);

            }
            
            
            string command = Console.ReadLine();
            string[] testWords = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (command == "Test")
            { 
                wordList.FirstOrDefault(x => x.WordName == testWords[0]);
                wordList.FirstOrDefault(x => x.WordName == testWords[0]).WordDescriptions.Add(testWords[1]);

                foreach(Word word in wordList)
                {
                    Console.WriteLine(word);
                }
            }
            else if(command == "Hand Over")
            {

            }
        }

        class Word
        {
            public string WordName { get; set; }

            public List<string> WordDescriptions { get; set;}
        }
    }
}