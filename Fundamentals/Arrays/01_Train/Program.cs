namespace _01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            A train has n number of wagons(integer, received as input).On the next n lines, you will receive the number of
            people that are going to get on each wagon. Print out the number of passengers in each wagon followed by the
            total number of passengers on the train.
            */

            //input

            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            int [] passengerArray = new int[n];    
            for (int i = 0; i < n; i ++)
            {
                passengerArray[i] = int.Parse(Console.ReadLine()); 
                sum += passengerArray[i];
            }
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(passengerArray[i] + " ");
            }

            Console.WriteLine();    

            Console.WriteLine(sum);

        }
    }
}