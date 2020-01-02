using System.Text;

namespace Problem_03_Student
{
    public class Student
    {
        // Field
        private string firstName = "Pesho";

        // Field
        private string middleName = null;

        // Field
        private string lastName = "Peshev";

        // Field
        private string facultyNumber = null;

        // Field
        private string course = null;

        // Field
        private int year = 1;

        public Student()
        {
        }

        public Student(string firstName, string lastName, string facultyNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.facultyNumber = facultyNumber;
        }

        public Student(string firstName, string lastName, string facultyNumber, string course)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.facultyNumber = facultyNumber;
            this.course = course;
        }

        public Student(string firstName, string middleName, string lastName, string facultyNumber, int year)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.facultyNumber = facultyNumber;
            this.year = year;
        }

        public Student(string firstName, string middleName, string lastName, string facultyNumber, string course, int year)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.facultyNumber = facultyNumber;
            this.course = course;
            this.year = year;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string middleName = this.middleName == null ? string.Empty : (" " + this.middleName);
            string facultyNumber = this.facultyNumber == null ? "N\\A" : this.facultyNumber;
            string course = this.course == null ? "N\\A" : this.course;

            sb.AppendLine($"{this.firstName}{middleName} {this.lastName}");
            sb.AppendLine($"Faculty Number: {facultyNumber}");
            sb.AppendLine($"Course: {course}; Year = {year}");
            return sb.ToString();
        }

    }
}
