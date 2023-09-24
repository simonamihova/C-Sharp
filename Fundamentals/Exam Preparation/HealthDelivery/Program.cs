namespace HealthDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] neighbourhood = Console.ReadLine()
                                         .Split("@")
                                         .Select(int.Parse)
                                         .ToArray();
            int cupidJumpLength = 0;
            int cupidCurrentIndex = 0;
            int failedHouseCount = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Love!")
                {
                    break;
                }

                string[] inputArr = input.Split(" ")
                                         .ToArray();
                cupidJumpLength = int.Parse(inputArr[1]);

                cupidCurrentIndex += cupidJumpLength;

                if (cupidCurrentIndex >= neighbourhood.Length)
                {
                    cupidCurrentIndex = 0;
                }

                neighbourhood[cupidCurrentIndex] -= 2;

                if (neighbourhood[cupidCurrentIndex] == 0)
                {
                    Console.WriteLine($"Place {cupidCurrentIndex} has Valentine's day.");
                }

                if (neighbourhood[cupidCurrentIndex] < 0)
                {
                    Console.WriteLine($"Place {cupidCurrentIndex} already had Valentine's day.");
                }
                failedHouseCount = 0;

                for(int i = 0; i < neighbourhood.Length; i++)
                {
                    if (neighbourhood[i] != 0)
                    {
                        failedHouseCount++;
                    }
                }
            }

            if (failedHouseCount != 0)
            {
                Console.WriteLine($"Cupid has failed {failedHouseCount} places.");
                Console.WriteLine($"Cupid's last position was {cupidCurrentIndex}.");
                return;
            }
            
            Console.WriteLine($"Cupid's last position was {cupidCurrentIndex}.");
            Console.WriteLine("Mission was successful.");
        }
    }
}