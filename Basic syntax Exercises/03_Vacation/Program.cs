namespace _03_Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeeek = Console.ReadLine();

            double totalPrice = 0;

            if (groupType == "Students")
            {
                if (dayOfWeeek == "Friday")
                {
                    totalPrice = peopleCount * 8.45;
                }
                else if (dayOfWeeek == "Saturday")
                {
                    totalPrice = peopleCount * 9.80;
                }
                else if (dayOfWeeek == "Sunday")
                {
                    totalPrice = peopleCount * 10.46;
                }

                if (peopleCount >= 30)
                {
                    totalPrice = totalPrice - (totalPrice * 0.15);
                }
            }
            else
            if (groupType == "Business")
            {
                if (peopleCount >= 100)

                    peopleCount -= 10;
                {
                    if (dayOfWeeek == "Friday")
                    {
                        totalPrice = peopleCount * 10.90;
                    }
                    else if (dayOfWeeek == "Saturday")
                    {
                        totalPrice = peopleCount * 15.60;
                    }
                    else if (dayOfWeeek == "Sunday")
                    {
                        totalPrice = peopleCount * 16;
                    }

                } 
            }
            else
            if (groupType == "Regular")
            {
                if (dayOfWeeek == "Friday")
                {
                    totalPrice = peopleCount * 15;
                }
                else if (dayOfWeeek == "Saturday")
                {
                    totalPrice = peopleCount * 20;
                }
                else if (dayOfWeeek == "Sunday")
                {
                    totalPrice = peopleCount * 22.50;
                }

                if(peopleCount >= 10 && peopleCount <= 20)
                {
                    totalPrice = totalPrice - (totalPrice * 0.05);
                }
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}