namespace _10_RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int lostGames = int.Parse(Console.ReadLine());  
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());


            int trashedHeadsets = 0;
            int trashedMice = 0;
            int trashedKeybords = 0;
            int trashedDisplayss = 0;
            float totalSum = 0;

            for(int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                  
                    trashedKeybords ++;
                    if (trashedKeybords % 2 == 0)
                    {
                        trashedDisplayss ++;
                    }
                    
                }
                if (i % 2 == 0)
                {
                    trashedHeadsets ++;
                }
                if(i % 3 == 0)
                {
                    trashedMice ++;
                }
                
            }

            totalSum = (trashedHeadsets * headsetPrice) + (trashedKeybords * keyboardPrice) + (trashedDisplayss * displayPrice) + (trashedMice * mousePrice);

            Console.WriteLine($"Rage expenses: {totalSum:F2} lv.");
        }
    }
}