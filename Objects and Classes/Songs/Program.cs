namespace Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs= new List<Song>();

            for(int i = 0;  i < numberOfSongs; i++)
            {
                string[] dataArr =  Console.ReadLine()
                                     .Split("_")
                                     .ToArray();
                string type = dataArr[0];
                string name = dataArr[1];
                string time = dataArr[2];

                Song currSong = new Song();

                currSong.TypeList = type;
                currSong.Name = name;
                currSong.Time = time;

                songs.Add(currSong);

            }

            string typeOfSongs = Console.ReadLine();

            if(typeOfSongs == "all")
            {
                foreach(Song song  in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach(Song song  in songs)
                {
                    if(song.TypeList == typeOfSongs)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
            
        }
    }
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public Song()
        {

        }
    }

}