using System;

namespace Problem_02_Person
{
    public class Student : Person
    {
        // field
        private string course;

        // field
        private int group;

        // field
        private string facultyNumber;

        public string Course
        {
            get { return this.course; }
        }

        public int Group
        {
            get { return this.group; }
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
        }

        public Student() : base()
        {
            Console.Write("Course = ");
            this.course = Console.ReadLine();
            Console.Write("Group = ");
            this.group = int.Parse(Console.ReadLine());
            Console.Write("Faculty Number = ");
            this.facultyNumber = Console.ReadLine();
        }

        public void ChangeGroup()
        {
            Console.Write("Group = ");
            this.group = int.Parse(Console.ReadLine());
        }

        public Student(string course, int group, string facultyNumber) : base("Pesho", "Peshev", "Peshev", "0987654321", "123QWERTY")
        {
            this.course = course;
            this.group = group;
            this.facultyNumber = facultyNumber;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine($"Course: {this.Course}");
            Console.WriteLine($"Group: {this.Group}");
            Console.WriteLine($"Faculty Number = {this.FacultyNumber}");
        }

        public void ShowFullInfo()
        {
            this.ShowPersonInfo();
            this.ShowStudentInfo();
        }
    }
}
