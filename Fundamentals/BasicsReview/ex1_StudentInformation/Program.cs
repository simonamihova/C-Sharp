﻿namespace ex1_StudentInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double avgGrade = double.Parse(Console.ReadLine());


            Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {avgGrade:F2}");

         
        }
    }
}