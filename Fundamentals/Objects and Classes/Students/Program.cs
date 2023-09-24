namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> StudentList = new List<Student>(); 
            
            bool IsStudentExisting(string FName, string LName)
            {
                foreach(Student student in StudentList)
                {
                    if(FName == student.FirstName&& LName == student.LastName)
                    {
                        StudentList.Remove(student);
                        return true;
                    }  
                }
                return false;
            }

            while(true) 
            {
                string input = Console.ReadLine();   
                if(input == "end")
                {
                    break;
                }

                string[] studentData = input.Split(" ").ToArray();
                string fName = studentData[0];
                string lName = studentData[1];
                int age = int.Parse(studentData[2]);
                string town = studentData[3];

                Student currStudent = new Student();



                if(IsStudentExisting(fName, lName))
                {
                    currStudent.FirstName = fName;
                    currStudent.LastName = lName;
                    currStudent.Age = age;
                    currStudent.HomeTown = town;
                    StudentList.Add(currStudent);
                }
                else
                {
                    Student updatedStudent= new Student();
                    updatedStudent.FirstName = fName;
                    updatedStudent.LastName = lName;
                    updatedStudent.Age = age;
                    updatedStudent.HomeTown = town;
                    StudentList.Add(updatedStudent);
                }
               
                
            }

            string townName = Console.ReadLine();

            foreach(Student student in StudentList)
            {
                if(student.HomeTown == townName) 
                { 
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}