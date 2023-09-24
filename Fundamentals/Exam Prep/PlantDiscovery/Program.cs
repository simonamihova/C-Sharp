using System.Data;

namespace PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Plant> plants = new List<Plant>();

            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] inputArr = input.Split("<->").ToArray();
                string plantName = inputArr[0];
                int plantRarity = int.Parse(inputArr[1]);


                if(plants.Any(x=> x.Name == plantName))
                {
                    plants.FirstOrDefault(x=> x.Name == plantName).Rarity = plantRarity;
                }
                else
                {
                    Plant plant = new Plant(plantName, plantRarity);
                    plants.Add(plant);
                }
            }

            string command = Console.ReadLine();

            while(true)
            {
                if (command == "Exhibition")
                {
                    break;
                }

                var commandArr = command.Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries);
                string commandName = commandArr[0];
                string plantName = commandArr[1];

                //Plant plant = plants.FirstOrDefault(p => p.Name == plantName);

                if (!plants.Any(x => x.Name == plantName))
                {
                    Console.WriteLine("error");

                    continue;
                }


                if (commandName == "Rate")
                {
                    decimal raiting = decimal.Parse(commandArr[2]);
                    //plant.Ratings.Add(raiting);
                    plants.FirstOrDefault(x => x.Name == plantName).Ratings.Add(raiting);
                }

                else if (commandName == "Update")
                {
                    int newrarity = int.Parse(commandArr[2]);
                    //plant.Rarity = newrarity;
                    plants.FirstOrDefault(x => x.Name == plantName).Rarity = newrarity;
                }

                if (commandName == "Reset")
                {
                    //plant.Ratings = new List<decimal>();
                    //plant.Ratings.Add(0);
                    plants.FirstOrDefault(x => x.Name == plantName).Ratings = new List<decimal>();
                    plants.FirstOrDefault(x => x.Name == plantName).Ratings.Add(0);
                }

                command= Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (Plant plant in plants)
            {
                /*if (plant.Ratings is null)
                {
                    plant.Ratings.Add(0);
                }*/
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {plant.Ratings.Average():F2}");
            }
          
        }

        class Plant
        {
            public Plant(string name, int rarity)
            {
                Name = name;
                Rarity = rarity;
                Ratings = new List<decimal> { };
            }

            public string Name { get; set; }

            public int Rarity { get; set; }

            public List<decimal> Ratings { get; set; }
        }
    }
}