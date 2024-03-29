﻿using System;

namespace _07_VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            string input = Console.ReadLine();

            while (input != "Start")
            {
                double coin = double.Parse(input);

                if (coin == 0.1 ||
                   coin == 0.2 ||
                   coin == 0.5 ||
                   coin == 1 ||
                   coin == 2)
                {
                    sum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                input = Console.ReadLine();

            }


            input = Console.ReadLine();

            while (input != "End")
            {
                

                switch (input)
                {
                    case "Nuts":
                        if (sum >= 2.0)
                        {
                            sum -= 2.0;
                            Console.WriteLine("Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        
                        }
                     break;
                    case "Water":
                        if (sum >= 0.7)
                        {
                            sum -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            
                        }
                        break;
                    case "Crisps":
                        if (sum >= 1.5)
                        {
                            sum -= 1.5;
                            Console.WriteLine("Purchased crisps");
                      
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                           
                        }
                        break;
                    case "Soda":
                        if (sum >= 0.8)
                        {
                            sum -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            
                        }
                        break;

                    case "Coke":
                        if (sum >= 1.0)
                        {
                            sum -= 1.0;
                            Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        break;

                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
   
