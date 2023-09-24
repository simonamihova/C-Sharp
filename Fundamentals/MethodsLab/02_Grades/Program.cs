namespace _02_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a method that receives a grade between 2.00 and 6.00 and prints the corresponding grade definition:
                • 2.00 – 2.99 - "Fail"
                • 3.00 – 3.49 - "Poor"
                • 3.50 – 4.49 - "Good"
                • 4.50 – 5.49 - "Very good"
                • 5.50 – 6.00 - "Excellent"*/

            double grade = double.Parse(Console.ReadLine());
            GradingMethod(grade);
        }
        static void GradingMethod(double grade)
        {
            if (grade >= 2.00 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                Console.WriteLine("Inavlid Grade");
            }
        }
    }
}