using System;

namespace Project_Student
{
    class StartUp
    {
        static void Main()
        {
            Student[] students = new Student[5];

            Student student_1 = new Student();
            Student student_2 = new Student("Pesho", "Ivanov", "1234567");
            Student student_3 = new Student("ivan", "Peshev", "7654321");
            student_3.FirstName = "Ivan";
            Student student_4 = new Student("maria", "stefanova", "9876543");
            student_4.MiddleName = "Ivanova";
            student_4.LastName = "Stefanova";
            Student student_5 = new Student();
            student_5.MiddleName = null;

            students[0] = student_1;
            students[1] = student_2;
            students[2] = student_3;
            students[3] = student_4;
            students[4] = student_5;

            Console.WriteLine();
            Console.WriteLine(new string('-', 15));
            Console.Write("Search (by faculty number): ");
            string facNumberToFind = Console.ReadLine();
            Console.WriteLine(new string('-', 15));

            bool hasFound = false;
            foreach (var student in students)
            {
                if (student.IsMatchingFacultyNumber(facNumberToFind))
                {
                    student.PrintInfo();
                    Console.WriteLine();
                    hasFound = true;
                }
            }

            if (!hasFound)
            {
                Console.WriteLine("No results...");
            }
        }
    }
}
