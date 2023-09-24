using System.Threading;

namespace MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;

            string[] rooms = Console.ReadLine()
                                        .Split("|")
                                        .ToArray();
            int bestRoom = 1;

            foreach (string room in rooms)
            {
                bestRoom++;
                string[] separateRoom = room.Split(" ")
                                            .ToArray();

                string encounter = separateRoom[0];
                int amount = int.Parse(separateRoom[1]);
                
                if(encounter == "potion")
                {

                    if ((health + amount) > 100)
                    {
                        amount = 100 - health;
                        health = 100;
                        Console.WriteLine($"You healed for {amount} hp.");
                    }
                    else
                    {
                        health += amount;
                        Console.WriteLine($"You healed for {amount} hp.");   
                    }
                    Console.WriteLine($"Current health: {health} hp.");
                    continue;
                }
                if (encounter == "chest")
                {
                    bitcoins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                    continue;
                }

                health -= amount;

                if (health < 0)
                {
                    Console.WriteLine($"You died! Killed by {encounter}.");
                    Console.WriteLine($"Best room: {bestRoom}");
                    return;
                }

                Console.WriteLine($"You slayed {encounter}.");
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}