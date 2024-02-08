namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> customers = new Queue<string>();

            
            while (input != "End")
            {


                if (input == "Paid")
                {
                    while (customers.Count > 0)
                    {
                        string currentCustomer = customers.Dequeue();
                        Console.WriteLine($"{currentCustomer}");
                    }
                }
                else
                {

                    customers.Enqueue(input);

                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}