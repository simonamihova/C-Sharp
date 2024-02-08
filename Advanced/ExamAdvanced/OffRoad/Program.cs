namespace OffRoad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
              
                int[] initialFuel = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int[] consumptionIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int[] neededFuel = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int AltitudesToTop = consumptionIndexes.Length;

                Stack<int> initFuel= new Stack<int>(initialFuel);
                Queue<int> consumption = new Queue<int>(consumptionIndexes);
                Queue<int> neededF = new Queue<int>(neededFuel);

                int altitudeCounter = 0;

                List<string> reachedAltitudes = new List<string>();

                while (initFuel.Count > 0)
                {
                    int currentInitFuel = initFuel.Pop();
                    int currentConsuption = consumption.Dequeue();
                    int currentSubstraction = currentInitFuel - currentConsuption;
                    int currentFuelNeeded = neededF.Dequeue();
                    if ( currentSubstraction >= currentFuelNeeded)
                    {
                        altitudeCounter++;
                        Console.WriteLine($"John has reached: Altitude {altitudeCounter}");
                        reachedAltitudes.Add($"Altitude {altitudeCounter}");
                    }
                    else if(currentFuelNeeded > currentSubstraction)
                    {
                        Console.WriteLine($"John did not reach: Altitude {altitudeCounter + 1 }");
                        break;
                    }
                }
                
                if(altitudeCounter > 0 && altitudeCounter < AltitudesToTop)
                {
                    Console.WriteLine("John failed to reach the top.");
                    Console.Write("Reached altitudes: ");
                    Console.WriteLine(string.Join(", ", reachedAltitudes));

                }
                else if(altitudeCounter == AltitudesToTop)
                {
                    Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
                }
                else if (altitudeCounter == 0)
                {
                    Console.WriteLine("John failed to reach the top.");
                    Console.WriteLine("John didn't reach any altitude.");
                }

            }
        }
    }
}