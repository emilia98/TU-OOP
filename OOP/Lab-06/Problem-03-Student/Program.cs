using System;

namespace Problem_03_Student
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student();
            Student student2 = new Student("Ivan", "Ivanov", "123456789");
            Student student3 = new Student("Ivan", "Ivanov", "123456789", "KST");
            Student student4 = new Student("Ivan", "Ivanov", "Ivanov", "123456789", 2017);
            Student student5 = new Student("Ivan", "Ivanov", "Ivanov", "123456789", "KST", 2017);

            Console.WriteLine("Student 1");
            Console.WriteLine(student1);

            Console.WriteLine();

            Console.WriteLine("Student 2");
            Console.WriteLine(student2);

            Console.WriteLine();

            Console.WriteLine("Student 3");
            Console.WriteLine(student3);

            Console.WriteLine("Student 4");
            Console.WriteLine(student4);

            Console.WriteLine();

            Console.WriteLine("Student 5");
            Console.WriteLine(student5);
        }
    }
}
