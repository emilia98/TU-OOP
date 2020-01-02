using System;
using System.Collections.Generic;

namespace Problem_03_Student
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            Student student1 = new Student();
            student1.EnterStudentData();
            students.Add(student1.FacultyNumber, student1);

            Console.WriteLine(new string('-', 25));

            Student student2 = new Student();
            student2.EnterStudentData();
            students.Add(student2.FacultyNumber, student2);

            Console.Write("Enter Faculty Number = ");
            string facNum = Console.ReadLine();

            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;

            if (students.ContainsKey(facNum))
            {
                Student studentFound = students[facNum];

                Console.WriteLine(studentFound.FullName);
                Console.WriteLine(studentFound.FacultyNumber);
                Console.WriteLine(studentFound.Course);
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }
    }
}
