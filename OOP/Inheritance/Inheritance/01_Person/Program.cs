using System.Text;

namespace _01_Person
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Name: {this.Name}");
                sb.AppendLine($"Age: {this.Age}");
                return sb.ToString();
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}