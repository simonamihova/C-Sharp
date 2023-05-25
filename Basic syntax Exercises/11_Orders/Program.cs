namespace _11_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int N = int.Parse(Console.ReadLine());
            double totalPrice = 0;


            for (int i = 0; i<N; i++)
            {
                double capsulePrice =  double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());   
                int capsuleCount = int.Parse(Console.ReadLine());

                double priceForOrder = (days * capsuleCount) * capsulePrice;

                Console.WriteLine($"The price for the coffee is: ${priceForOrder:F2}");

                totalPrice += priceForOrder;

            }
            
        
            Console.WriteLine($"Total: ${totalPrice:F2}");


        }
    }
}