using System;

namespace Problem_03_Student
{
    public class Student
    {
        // Field
        private string firstName;

        // Field
        private string lastName;

        // Field
        private string facultyNumber;

        // Field
        private string course;

        public string FirstName => firstName;

        public string LastName => lastName;

        public string FullName => $"{FirstName} {LastName}";

        public string FacultyNumber => facultyNumber;

        public string Course => course;

        public void EnterStudentData()
        {
            Console.Write("First Name = ");
            firstName = Console.ReadLine();
            Console.Write("Last Name = ");
            lastName = Console.ReadLine();
            Console.Write("Faculty Number = ");
            facultyNumber = Console.ReadLine();
            Console.Write("Course = ");
            course = Console.ReadLine();
        }
    }
}
