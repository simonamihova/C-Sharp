using System.Diagnostics;

namespace ComputerReceipt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  1050
                200
                450
                2
                18.50
                16.86
                special
            */

           
            bool isSpecial = false;
            double totalPrice = 0;
            double price = 0;
            double totalPriceWithNoTax = 0;
            double noTaxSum = 0;
           
            while(true)
            {
                string input = Console.ReadLine();

                if (input == "regular" || input == "special")
                {
                    if (input == "special")
                    {
                        isSpecial = true;
                        break;
                    }
                    break;
                }

                double currentPrice = double.Parse(input);
               

                if (currentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                price = currentPrice + (currentPrice * 0.2);
                totalPrice += price;
            }

            if (totalPriceWithNoTax == 0)
            {
                Console.WriteLine("Inavalid order!");
                return;
            }
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPriceWithNoTax:F2}$");
            Console.WriteLine($"Taxes: {(totalPriceWithNoTax * 0.2):F2}$");
            Console.WriteLine("-----------");
            if (isSpecial)
            {
                totalPrice = totalPrice * 0.90;
                Console.WriteLine($"Total price: {totalPrice:F2}$");
                return;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}$");

        }
    }
}