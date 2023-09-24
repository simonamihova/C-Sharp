namespace _01_DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enter a number in range 1-7 and print out the word representing it or "Invalid Day!". Use an array of strings.

            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int number = int.Parse(Console.ReadLine());
            

            if(number < 1 || number > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                number = number - 1;
                Console.WriteLine($"{weekDays[number]}");
            }
        }
    }
}