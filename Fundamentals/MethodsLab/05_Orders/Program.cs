using System.Diagnostics.Metrics;

namespace _05_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that calculates and prints the total price of an order. The method should receive two parameters:
            
            string product =  Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"{TotalPriceCalculator(product, quantity):F2}");
           
            
        }

        /*
         The method should receive two parameters:
            • A string, representing a product - "coffee", "water", "coke", "snacks"
            • An integer, representing the quantity of the product
         */

        static double TotalPriceCalculator(string product, int quantity)
        {
            /*
            The prices for a single item of each product are:
            • coffee – 1.50
            • water – 1.00
            • coke – 1.40
            • snacks – 2.00
           
           Print the result, rounded to the second decimal place.
             */
            double totalPrice = 0;
            switch (product)
            {
                case "coffee":
                    totalPrice += quantity * 1.50;
                break;
                case "water":
                    totalPrice += quantity * 1.00;
                break;
                case "coke":
                    totalPrice += quantity * 1.40;
                break;
                case "snacks":
                    totalPrice += quantity * 2.00;
                break;
                default:
                    Console.WriteLine("Invalid Input"); 
                break;
            }

            return totalPrice;
        }
    }
}